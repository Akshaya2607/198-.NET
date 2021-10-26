using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPagesDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID.ToString();
            Label2.Text = Session.IsNewSession.ToString();
            Label3.Text = Session.IsCookieless.ToString();
            Label4.Text = Application["cnt"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtpwd.Text == "abc@123")
            {
                Session["username"] = txtuser.Text;
                Response.Redirect("~/Statement.aspx");
            }
            else
            {
                Response.Write("Check username and password");
            }
        }
    }
}