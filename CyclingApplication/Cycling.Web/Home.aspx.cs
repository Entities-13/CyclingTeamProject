﻿using Cycling.Common;
using Cycling.Data;
using Cycling.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonAddJsonData_Click(object sender, EventArgs e)
        {
            string filePath = HttpContext.Current.Server.MapPath("~/Common/JsonData/CyclistsData.json");

            var cyclistsFromJson = new LoadDataFromJson();

            var cyclists = cyclistsFromJson.LoadData(filePath);

            var dbContext = new CyclingDbContext();
            foreach (var item in cyclists)
            {
                dbContext.Cyclists.Add(item);
            }

            dbContext.SaveChanges();
        }
    }
}