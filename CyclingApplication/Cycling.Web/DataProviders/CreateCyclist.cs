﻿using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using Cycling.Web.Common;
using Cycling.Web.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Cycling.Models;

namespace Cycling.Web.DataProviders
{
    public class CreateCyclist : ICreateCyclist
    {
        private string firstName;
        private string lastName;
        private int age;
        private int tourDeFranceWins;
        private int giroDItaliaWins;
        private int vueltaWins;
        private string currentTeam;

        public CreateCyclist(string firstName, string lastName, int age, int tourWins, int giroWins, int vueltaWins, string team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.TourDeFranceWins = tourWins;
            this.GiroDItaliaWins = giroWins;
            this.VueltaWins = vueltaWins;
            this.CurrentTeam = team;
        }

        // added for bulk insertion of data 
        public CreateCyclist(ICollection<Cyclist> cyclists)
        {
            this.Cyclists = cyclists;
        }

        public ICollection<Cyclist> Cyclists { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MAX_STRING_LENGTH, Constants.INVALID_FIRST_NAME_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, Constants.INVALID_FIRST_NAME_MSG);
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MAX_STRING_LENGTH, Constants.INVALID_LAST_NAME_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, Constants.INVALID_LAST_NAME_MSG);
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                Validator.CheckIfNull(value, Constants.INVALID_INT_MSG);
                age = value;
            }
        }

        public int TourDeFranceWins
        {
            get
            {
                return tourDeFranceWins;
            }
            set
            {
                Validator.CheckIfNull(value, Constants.INVALID_INT_MSG);
                tourDeFranceWins = value;
            }
        }

        public int GiroDItaliaWins
        {
            get
            {
                return giroDItaliaWins;
            }
            set
            {
                Validator.CheckIfNull(value, Constants.INVALID_INT_MSG);
                giroDItaliaWins = value;
            }
        }

        public int VueltaWins
        {
            get
            {
                return vueltaWins;
            }
            set
            {
                Validator.CheckIfNull(value, Constants.INVALID_INT_MSG);
                vueltaWins = value;
            }
        }

        public string CurrentTeam
        {
            get
            {
                return currentTeam;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MAX_STRING_LENGTH + 10, Constants.INVALID_TEAM_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, Constants.INVALID_TEAM_MSG);
                currentTeam = value;
            }
        }

        public void CreateOne()
        {
            var cyclistNew = new Cyclist()
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                Age = this.age,
                TourDeFranceWins = this.tourDeFranceWins,
                GiroDItaliaWins = this.giroDItaliaWins,
                VueltaEspanaWins = this.vueltaWins,
                CurrentTeam = this.currentTeam
            };

            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                unitOfWork.CyclistsRepository.Add(cyclistNew);

                unitOfWork.Commit();
            }
        }

        public void CreateMany()
        {
            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                var cyclistsInDb = unitOfWork.CyclistsRepository.GetAll().ToList();

                foreach (var item in this.Cyclists)
                {
                    if (!cyclistsInDb.Exists(x =>
                                x.FirstName.ToLower() == item.FirstName.ToLower() &&
                                x.LastName.ToLower() == item.LastName.ToLower()))
                    {
                        unitOfWork.CyclistsRepository.Add(item);
                    }

                }

                unitOfWork.Commit();
            }
        }

        public static void AddFromList(CyclingDbContext db, IList<TourData> list)
        {
            string fn, ln;
            CyclistNext cyclist;
            TourDeFrance tourDeFrance;
            var dbBefor = db.CyclistNext.ToList();

            foreach (var row in list)
            {
                fn = row.FullName.Split(' ')[0];
                ln = row.FullName.Split(' ')[1];

                cyclist = (new CyclistNext()
                {
                    FirstName = fn,
                    LastName = ln,
                    BirthDay = row.BirtdayOfWinner,
                    Nationality = row.Nationalite,
                });

                tourDeFrance = (new TourDeFrance()
                {
                    Stage = row.EtapsCount,
                    TimeOfWinner = row.TimeOfWinner,
                    Year = row.Year,
                    Distance = row.Distance
                });

                var index = dbBefor.FindIndex(x => x.FirstName == fn &&
                                                   x.LastName == ln &&
                                                   x.BirthDay == row.BirtdayOfWinner);
                if (index == -1)
                {
                    db.CyclistNext.Add(cyclist);
                    dbBefor.Add(cyclist);
                    tourDeFrance.CyclistNext_Id = cyclist;
                    db.TourDeFrance.Add(tourDeFrance);
                }
                else
                {
                    var maxDate = db.TourDeFrance.Max(x => x.Year);
                    if (maxDate < row.Year)
                    {
                        tourDeFrance.CyclistNext_Id = dbBefor[index];
                        db.TourDeFrance.Add(tourDeFrance);
                    }

                }

                db.SaveChanges();
            }
        }
    }
}