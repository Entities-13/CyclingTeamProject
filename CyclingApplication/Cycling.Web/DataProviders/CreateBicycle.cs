using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using Cycling.Web.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cycling.Web.DataProviders
{
    public class CreateBicycle : ICreateBicycle
    {
        public void CreateMany(ICollection<Bicycle> bicycles)
        {
            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                var bicyclesInDb = unitOfWork.BicyclesRepository.GetAll().ToList();

                foreach (var item in bicycles)
                {
                    if (!bicyclesInDb.Exists(x =>
                                x.Brand.ToLower() == item.Brand.ToLower() &&
                                x.Model.ToLower() == item.Model.ToLower()))
                    {
                        unitOfWork.BicyclesRepository.Add(item);
                    }

                }

                unitOfWork.Commit();
            }
        }
    }
}