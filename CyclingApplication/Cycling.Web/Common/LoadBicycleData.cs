using Cycling.Models.MSSQL;
using Cycling.Web.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

namespace Cycling.Web.Common
{
    public class LoadBicycleData : ILoadJsonData<Bicycle>
    {
        public ICollection<Bicycle> LoadDataFromJson(string filePath)
        {
            dynamic json = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(filePath));
            var collectionOfBicycles = new List<Bicycle>();
            foreach (var item in json)
            {
                var bicycle = JsonConvert.DeserializeObject<Bicycle>(item.ToString());
                collectionOfBicycles.Add(bicycle);
            }

            return collectionOfBicycles;
        }
    }
}