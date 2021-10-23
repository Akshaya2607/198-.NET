using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Cart"];
            int cnt = cookie.Values.Count;
            for(int i=0;i<cnt;i++)
            {
                ListBox2.Items.Add(cookie.Values[i]);
                
            }
            
        }
    }
}