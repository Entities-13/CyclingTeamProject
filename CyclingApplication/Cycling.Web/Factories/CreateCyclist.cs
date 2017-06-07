using Cycling.Data;
using Cycling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cycling.Web.Factories
{
    public class CreateCyclist
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

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int TourDeFranceWins
        {
            get { return tourDeFranceWins; }
            set { tourDeFranceWins = value; }
        }

        public int GiroDItaliaWins
        {
            get { return giroDItaliaWins; }
            set { giroDItaliaWins = value; }
        }

        public int VueltaWins
        {
            get { return vueltaWins; }
            set { vueltaWins = value; }
        }

        public string CurrentTeam
        {
            get { return currentTeam; }
            set { currentTeam = value; }
        }

        public void Create()
        {
            var cyclist = new Cyclist()
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
                dbContext.Cyclists.Add(cyclist);

                dbContext.SaveChanges();
            }
        }
    }
}