using Cycling.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Common
{
    public class LoadDataFromJson
    {
        public ICollection<Cyclist> LoadcyClistsDataFromJson()
        {
            dynamic json = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("../../JsonData/CyclistsData.json"));
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
