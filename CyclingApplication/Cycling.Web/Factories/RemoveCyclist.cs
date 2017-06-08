﻿using Cycling.Data;
using Cycling.Web.Common;
using Cycling.Web.Contracts;
using System.Linq;

namespace Cycling.Web.Factories
{
    public class RemoveCyclist : IRemoveCyclist
    {
        private string firstName;
        private string lastName;

        public RemoveCyclist(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

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

        // TODO: maybe implement remove by Id not by first and last name
        public void Remove()
        {
            using (var dbContext = new CyclingDbContext())
            {
                var cyclistsToRemove = dbContext.Cyclists.Where(x => x.FirstName.Contains(this.FirstName)
                                && x.LastName.Contains(this.LastName)).ToList();

                foreach (var cyclist in cyclistsToRemove)
                {
                    dbContext.Cyclists.Remove(cyclist);
                }
 
                dbContext.SaveChanges();
            }
        }
    }
}