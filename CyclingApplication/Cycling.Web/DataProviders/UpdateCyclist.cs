using Cycling.Data;
using Cycling.Web.Common;
using Cycling.Web.Contracts;
using System.Linq;

namespace Cycling.Web.DataProviders
{
    public class UpdateCyclist : IUpdateCyclist
    {
        private string firstName;
        private string lastName;
        private string age;
        private string tourDeFranceWins;
        private string giroDItaliaWins;
        private string vueltaWins;
        private string currentTeam;

        public UpdateCyclist(int parsedId, string firstName, string lastName, string age, string tourWins, string giroWins, string vueltaWins, string team)
        {
            this.ParsedId = parsedId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.TourDeFranceWins = tourWins;
            this.GiroDItaliaWins = giroWins;
            this.VueltaWins = vueltaWins;
            this.CurrentTeam = team;
        }
        public int ParsedId { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MAX_STRING_LENGTH, Constants.INVALID_FIRST_NAME_MSG);
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
                lastName = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string TourDeFranceWins
        {
            get
            {
                return tourDeFranceWins;
            }
            set
            {
                tourDeFranceWins = value;
            }
        }

        public string GiroDItaliaWins
        {
            get
            {
                return giroDItaliaWins;
            }
            set
            {
                giroDItaliaWins = value;
            }
        }

        public string VueltaWins
        {
            get
            {
                return vueltaWins;
            }
            set
            {
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
                currentTeam = value;
            }
        }

        public void Update()
        {
            using (var dbContext = new CyclingDbContext())
            {
                var cyclistsToUpdate = dbContext.Cyclists.Where(x => x.Id == this.ParsedId).FirstOrDefault();

                if (!string.IsNullOrEmpty(this.FirstName))
                {
                    cyclistsToUpdate.FirstName = this.FirstName;
                }

                if (!string.IsNullOrEmpty(this.LastName))
                {
                    cyclistsToUpdate.LastName = this.LastName;
                }

                if (!string.IsNullOrEmpty(this.Age))
                {
                    cyclistsToUpdate.Age = int.Parse(this.Age);
                }

                if (!string.IsNullOrEmpty(this.TourDeFranceWins))
                {
                    cyclistsToUpdate.TourDeFranceWins = int.Parse(this.TourDeFranceWins);
                }

                if (!string.IsNullOrEmpty(this.GiroDItaliaWins))
                {
                    cyclistsToUpdate.GiroDItaliaWins = int.Parse(this.GiroDItaliaWins);
                }

                if (!string.IsNullOrEmpty(this.VueltaWins))
                {
                    cyclistsToUpdate.VueltaEspanaWins = int.Parse(this.VueltaWins);
                }

                if (!string.IsNullOrEmpty(this.CurrentTeam))
                {
                    cyclistsToUpdate.CurrentTeam = this.CurrentTeam;
                }

                dbContext.SaveChanges();
            }
        }
    }
}