using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(txtitem.Text);
            txtitem.Text = "";
        }
        public static Hashtable h = new Hashtable();
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox2.Items.Add(ListBox1.SelectedValue);
            h.Add(ListBox1.SelectedItem.Text, ListBox1.SelectedValue);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Cart");

            //cookie.Values.Add(ListBox2.);
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                ListItem i = new ListItem();
                i.Text=ie.Key.ToString();
                i.Value = ie.Value.ToString();
                cookie.Values.Add(i.Text,i.Value);
                cookie.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/WebForm2.aspx");
        }
    }
}