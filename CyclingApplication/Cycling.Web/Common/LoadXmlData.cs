using Cycling.Models.MSSQL;
using Cycling.Web.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Cycling.Web.Common
{
    public class LoadXmlData : ILoadXmlData<Cyclist>
    {
        public void GetListOfWinner(XmlReader node, IList<TourData> tour)
        {
            const int columnInXml = 8;
            var element = new string[columnInXml];
            node.ReadToFollowing("Row");

            while (node.ReadToFollowing("Row"))
            {
                for (int i = 0; i < columnInXml; i++)
                {
                    if (node.ReadToFollowing("Cell") && node.ReadToFollowing("Data"))
                    {
                        element[i] = node.ReadElementContentAsString();
                    }
                }

                //parsing data
                tour.Add(new TourData()
                {
                    Year = DateTime.Parse("1-6-" + element[0]),
                    EtapsCount = int.Parse(element[1]),
                    Distance = int.Parse(element[2]),
                    TimeOfWinner = TimeSpan.FromHours(double.Parse(element[3].Split('.', ',')[0] + "," + element[3].Split('.', ',')[1])),
                    FullName = element[5],
                    BirtdayOfWinner = DateTime.Parse(element[7]),
                    Nationalite = element[6]
                });
            }
        }
    }
}
