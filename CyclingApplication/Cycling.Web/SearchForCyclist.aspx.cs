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
    public partial class SearchForCyclist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonDisplayCyclist_Click(object sender, EventArgs e)
        {
            var findCyclist = new FindCyclist(int.Parse(this.TextBoxId.Text));
            var cyclistToDisplay = findCyclist.Find();

            this.GridViewResult.DataSource = cyclistToDisplay;
            this.GridViewResult.DataBind();
        }
    }
}