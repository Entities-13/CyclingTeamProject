﻿using Cycling.Data;
using Cycling.Data.SQLite;
using Cycling.Models;
using Cycling.Models.SQLite;
using Cycling.Web.Common;
using Cycling.Web.DataProviders;
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
using System.Xml;

namespace Cycling.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddJsonData_Click(object sender, EventArgs e)
        {
            string filePathJson = HttpContext.Current.Server.MapPath("~/Common/DataToImport/CyclistsData.json");

            var loadCyclists = new LoadData();
            var cyclists = loadCyclists.LoadDataFromJson(filePathJson);

            var cyclistsFactory = new CreateCyclist(cyclists);
            cyclistsFactory.CreateMany();

            Response.Redirect("Cyclists.aspx");
        }

        protected void ButtonAddXmlData_Click(object sender, EventArgs e)
        {
            //getting xml - Tour de France
            var loadCyclists = new LoadData();
            //var cyclistsFactory = new CreateCyclist(cyclists);
            //cyclistsFactory.CreateMany();

            string filePathXml = HttpContext.Current.Server.MapPath("~/Common/DataToImport/France2.xml");
            var franceTour = new List<TourData>();
            // parsing from xml to list
            loadCyclists.GetListOfWinner(XmlReader.Create(filePathXml), franceTour);

            // seting from list DB
            CreateCyclist.AddFromList(new CyclingDbContext(), franceTour);

            Response.Redirect("Cyclists.aspx");
        }
    }
}