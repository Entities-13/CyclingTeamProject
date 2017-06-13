using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using Cycling.Web.Common;
using System.Collections.Generic;
using System.Linq;
using Cycling.Models;

namespace Cycling.Web.DataProviders
{
    public class CreateCyclistNext //: ICreateCyclist
    {
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