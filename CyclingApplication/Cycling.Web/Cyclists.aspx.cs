using Cycling.Data;
using Cycling.Models;
using Cycling.Web.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cyclists = new DisplayCyclists();

            if (!Page.IsPostBack)
            {
                this.GridViewCyclists.DataSource = cyclists.Display();
                this.GridViewCyclists.DataBind();
            }
        }
    }
}