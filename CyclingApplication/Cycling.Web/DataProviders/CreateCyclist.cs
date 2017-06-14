using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using Cycling.Web.Common;
using Cycling.Web.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Cycling.Web.DataProviders
{
    public class CreateCyclist : ICreateCyclist
    { 
        public void CreateOne(string firstName, string lastName, int age, int tourWins, int giroWins, int vueltaWins, string team)
        {
            var cyclistNew = new Cyclist()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                TourDeFranceWins = tourWins,
                GiroDItaliaWins = giroWins,
                VueltaEspanaWins = vueltaWins,
                CurrentTeam = team
            };

            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                unitOfWork.CyclistsRepository.Add(cyclistNew);
             
                unitOfWork.Commit();
            }
        }

        public void CreateMany(ICollection<Cyclist> cyclists)
        {
            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                var cyclistsInDb = unitOfWork.CyclistsRepository.GetAll().ToList();

                foreach (var item in cyclists)
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
    }
}