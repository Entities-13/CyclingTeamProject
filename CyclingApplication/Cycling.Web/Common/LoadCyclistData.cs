using Cycling.Models.MSSQL;
using Cycling.Web.Common.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Cycling.Web.Common
{
    public class LoadCyclistData : ILoadJsonData<Cyclist>
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
    }
}