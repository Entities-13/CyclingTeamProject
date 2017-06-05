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
        static void Main(string[] args)
        {
            var jsonObj = JsonConvert.DeserializeObject("");

            StreamReader re = new StreamReader("../../JsonData/CyclistsData.json");
            var sss = JsonConvert.SerializeObject("../../ JsonData/CyclistsData.json");
            Console.WriteLine(sss);
           var json = JObject.Parse(sss);
            //Console.WriteLine(parsedData[);
        }
    }
}
