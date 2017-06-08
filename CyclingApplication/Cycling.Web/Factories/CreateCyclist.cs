using Cycling.Data;
using Cycling.Models;
using Cycling.Web.Common;
using Cycling.Web.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cycling.Web.Factories
{
    public class CreateCyclist : ICreateCyclist
    {
        private const int MAX_STRING_LENGTH = 40;
        private const string INVALID_INT_MSG = "Can not be NULL";
        private const string INVALID_FIRST_NAME_MSG = "Invalid First Name";
        private const string INVALID_LAST_NAME_MSG = "Invalid Last Name";
        private const string INVALID_TEAM_MSG = "Invalid Team";

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
        public CreateCyclist(IEnumerable<Cyclist> cyclists)
        {
            this.Cyclists = cyclists;
        }

        public IEnumerable<Cyclist> Cyclists { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, MAX_STRING_LENGTH, INVALID_FIRST_NAME_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, INVALID_FIRST_NAME_MSG);
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
                Validator.CheckIfStringLengthIsValid(value, MAX_STRING_LENGTH, INVALID_LAST_NAME_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, INVALID_LAST_NAME_MSG);
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
                Validator.CheckIfNull(value, INVALID_INT_MSG);
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
                Validator.CheckIfNull(value, INVALID_INT_MSG);
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
                Validator.CheckIfNull(value, INVALID_INT_MSG);
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
                Validator.CheckIfNull(value, INVALID_INT_MSG);
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
                Validator.CheckIfStringLengthIsValid(value, MAX_STRING_LENGTH + 10, INVALID_TEAM_MSG);
                Validator.CheckIfStringIsNullOrEmpty(value, INVALID_TEAM_MSG);
                currentTeam = value;
            }
        }

        public void CreateOne()
        {
            var cyclist1 = new Cyclist()
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                Age = this.age,
                TourDeFranceWins = this.tourDeFranceWins,
                GiroDItaliaWins = this.giroDItaliaWins,
                VueltaEspanaWins = this.vueltaWins,
                CurrentTeam = this.currentTeam
            };

            using (var dbContext = new CyclingDbContext())
            {
                dbContext.Cyclists.Add(cyclist1);

                dbContext.SaveChanges();
            }
        }

        public void CreateMany()
        {
            using (var dbContext = new CyclingDbContext())
            {
                foreach (var item in this.Cyclists)
                {
                    dbContext.Cyclists.Add(item);
                }

                dbContext.SaveChanges();
            }
        }
    }
}