﻿using Cycling.Data.Common;
using Cycling.Data.SQLite;
using Cycling.Models.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cycling.Web
{
    public partial class SQLiteAndPostgre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFillSQLite_Click(object sender, EventArgs e)
        {
            var destination = new CyclingDestination();
            destination.Name = "Somewhere in Pirin";
            destination.Country = "Bulgaria";

            var instructor = new CyclingInstructor();
            instructor.Name = "Nikodim Nikodimov";
            instructor.Country = "Bulgaria";

            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContextSQLite()))
            {
                unitOfWork.CyclingDestinationsRepository.Add(destination);
                unitOfWork.CyclingInstructorsRepository.Add(instructor);

                unitOfWork.Commit();
            }
        }
    }
}