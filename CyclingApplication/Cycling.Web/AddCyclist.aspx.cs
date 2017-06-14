using Cycling.Web.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class AddCyclist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddNewCyclicst_Click(object sender, EventArgs e)
        {
            var cyclist = new CreateCyclist();

            cyclist.CreateOne(this.TextBoxFirstName.Text, this.TextBoxLastName.Text,
                int.Parse(this.TextBoxAge.Text), int.Parse(this.TextBoxTour.Text),
                int.Parse(this.TextBoxGiro.Text), int.Parse(this.TextBoxVuelta.Text),
                this.TextBoxTeam.Text);

            Response.Redirect("Cyclists.aspx");
        }
    }
}