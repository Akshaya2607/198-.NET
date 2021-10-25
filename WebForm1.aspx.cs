using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtdate.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void rdomale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdomale.Checked)
            {
                txtgender.Text = "Male";
            }
        }

        protected void rdofemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdofemale.Checked)
            {
                txtgender.Text = "Female";
            }
        }

        protected void rdoother_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoother.Checked)
            {
                txtgender.Text = "Other";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("http:\\www.google.com");
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}