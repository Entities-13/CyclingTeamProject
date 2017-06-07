using Cycling.Models;
using Cycling.Web.Common.Contracts;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Cycling.Web.Common
{
    public class LoadDataFromJson : ILoadData<Cyclist>
    {
        public IEnumerable<Cyclist> LoadData(string filePath)
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
