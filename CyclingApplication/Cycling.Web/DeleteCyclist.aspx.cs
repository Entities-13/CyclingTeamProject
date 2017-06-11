using Cycling.Data;
using Cycling.Web.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class DeleteCyclist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRemoveCyclicst_Click(object sender, EventArgs e)
        {
            var removeCyclist = new RemoveCyclist(this.TextBoxFirstName.Text, this.TextBoxLastName.Text);
            removeCyclist.Remove();

            Response.Redirect("Cyclists.aspx");
        }
    }
}