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
    public partial class UpdateCyclistPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUpdateCyclist_Click(object sender, EventArgs e)
        {
            var parsedId = int.Parse(this.TextBoxId.Text);

            var cyclistUpdate = new UpdateCyclist(parsedId, this.TextBoxFirstName.Text,
                this.TextBoxLastName.Text, this.TextBoxAge.Text, this.TextBoxTour.Text,
                this.TextBoxGiro.Text, this.TextBoxVuelta.Text, this.TextBoxTeam.Text);

            cyclistUpdate.Update();

            Response.Redirect("Cyclists.aspx");
        }
    }
}