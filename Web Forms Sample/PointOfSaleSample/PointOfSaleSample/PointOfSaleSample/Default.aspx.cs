using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PointOfSaleSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.professorName.Text = "Todavia no nos vamos";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            this.professorName.Text = "Vamonos para la casa";
        }
    }
}