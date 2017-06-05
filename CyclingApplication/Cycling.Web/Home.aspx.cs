using Cycling.Common;
using Cycling.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string absoluteSystemPath = Server.MapPath("~/relative/path.aspx");
            var cyclistsFromJson = new LoadDataFromJson();

            var cyclists= cyclistsFromJson.LoadcyClistsDataFromJson();
        }
    }
}