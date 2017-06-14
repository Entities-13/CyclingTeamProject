using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Data.SQLite;
using Cycling.Models;
using Cycling.Models.SQLite;
using Cycling.Web.Common;
using Cycling.Web.DataProviders;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Annotations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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

            var loadCyclists = new LoadCyclistData();
            var cyclists = loadCyclists.LoadDataFromJson(filePathJson);

            var cyclistsFactory = new CreateCyclist();
            cyclistsFactory.CreateMany(cyclists);

            Response.Redirect("Cyclists.aspx");
        }

        protected void ButtonAddXmlData_Click(object sender, EventArgs e)
        {
            //getting xml - Tour de France
            var loadCyclists = new LoadXmlData();

            string filePathXml = HttpContext.Current.Server.MapPath("~/Common/DataToImport/France2.xml");
            var franceTour = new List<TourData>();
            loadCyclists.GetListOfWinner(XmlReader.Create(filePathXml), franceTour);

            Response.Redirect("Cyclists.aspx");
        }

        protected void ButtonGeneratePDF_Click(object sender, EventArgs e)
        {
            var reportGenerator = new GeneratePDF();

            reportGenerator.GenerateReport(HttpContext.Current.Server.MapPath("~/Common/PDFReports/"));

            Response.Redirect("Cyclists.aspx");
        }

        protected void ButtonAddBicycleData_Click(object sender, EventArgs e)
        {
            string filePathJson = HttpContext.Current.Server.MapPath("~/Common/DataToImport/BicyclesData.json");

            var loadBicycles = new LoadBicycleData();
            var bicycles = loadBicycles.LoadDataFromJson(filePathJson);

            var bicyclesFactory = new CreateBicycle();
            bicyclesFactory.CreateMany(bicycles);
        }
    }
}