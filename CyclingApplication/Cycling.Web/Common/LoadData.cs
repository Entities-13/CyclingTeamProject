using Cycling.Models.MSSQL;
using Cycling.Web.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Linq;
using Castle.Core.Internal;

namespace Cycling.Web.Common
{
    public class LoadData : ILoadData<Cyclist>
    {
        public ICollection<Cyclist> LoadDataFromJson(string filePath)
        {
            dynamic json = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(filePath));
            var collectionOfCyclists = new List<Cyclist>();
            foreach (var item in json)
            {
                var cyclist = JsonConvert.DeserializeObject<Cyclist>(item.ToString());
                collectionOfCyclists.Add(cyclist);
            }

            return collectionOfCyclists;
        }

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
                //tour.Add
                var firstName = element[5].Split(' ')[0].Trim();
                var lastName = element[5].Split(' ')[1].Trim();
                if (IsAllUpparCase(firstName) && !IsAllUpparCase(lastName))
                {
                    var tr = lastName;
                    lastName = firstName;
                    firstName = tr;
                }

                tour.Add (new TourData()
                {
                    Year = DateTime.Parse("1-6-" + element[0]),
                    EtapsCount = int.Parse(element[1]),
                    Distance = int.Parse(element[2]),
                    TimeOfWinner = double.Parse(element[3].Split('.', ',')[0] + "," + element[3].Split('.', ',')[1]),
                    FullName = firstName + " " + lastName,
                    BirtdayOfWinner = DateTime.Parse(element[7]),
                    Nationalite = element[6]
                });
            }
        }

        private bool IsAllUpparCase(string name)
        {
            var isUpper = true;
            foreach (var ch in name)
            {
                isUpper &= char.IsUpper(ch);
            }
            return isUpper;
        }
    }
}
