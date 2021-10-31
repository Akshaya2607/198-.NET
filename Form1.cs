using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightBAL;
using FlightDAL;
namespace FlightDisconnectedDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DALFlightLayer dal = new DALFlightLayer();
            string s = dal.DeleteFlight(Convert.ToInt32(txtfid.Text));
            if (s != null)
                MessageBox.Show("Deleted Successfully .. ");
            button4_Click(sender, e);
            Form1_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtfid.Text = "";
            txtfname.Text = "";
            txtfarr.Text = "";
            txtfdep.Text = "";
            txtpcount.Text = "";
            txtcrid.Text = "";
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                BALFlightLayer bal = new BALFlightLayer();
                DALFlightLayer dal = new DALFlightLayer();
                bal.FlightID = Convert.ToInt32( txtfid.Text);
                bal.Flightname = txtfname.Text;
                bal.FArrival = Convert.ToDateTime(txtfarr.Text);
                bal.FDepart = Convert.ToDateTime(txtfdep.Text);
                bal.NoOfPassengers = Convert.ToInt32(txtpcount.Text);
                bal.CrewID = Convert.ToInt32(txtcrid.Text);

                string s = dal.InsertFlight(bal);
                if (s != null)
                {
                    MessageBox.Show("Record added Successfully");
                    Form1_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("record adding failed");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            BALFlightLayer bal = new BALFlightLayer();
            DALFlightLayer dal = new DALFlightLayer();
            bal.FlightID = Convert.ToInt32(txtfid.Text);
            bal = dal.FindFlight(bal.FlightID);
            txtfname.Text = bal.Flightname;
            txtfarr.Text = bal.FArrival.ToString();
            txtfdep.Text = bal.FDepart.ToString();
            txtpcount.Text = bal.NoOfPassengers.ToString();
            txtcrid.Text = bal.CrewID.ToString();
            DialogResult dr = MessageBox.Show("Do u want to edit this record?", "User Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                btnedit.Text = "Update";
                txtfname.Focus();
            }
        }

        private void txtcrid_leave(object sender, EventArgs e)
        {
            try
            {
                BALFlightLayer bal = new BALFlightLayer();
                DALFlightLayer dal = new DALFlightLayer();
                bal.FlightID = Convert.ToInt32(txtfid.Text);
                bal.Flightname = txtfname.Text;
                bal.FArrival = Convert.ToDateTime(txtfarr.Text);
                bal.FDepart = Convert.ToDateTime(txtfdep.Text);
                bal.NoOfPassengers = Convert.ToInt32(txtpcount.Text);
                bal.CrewID = Convert.ToInt32(txtcrid.Text);
                string s = dal.EditFlight(bal);
                if (s != null)
                    MessageBox.Show("Updated.... ");
                Form1_Load(sender, e);
            }
            catch (FormatException ex)
            {

                btninsert_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DALFlightLayer dal = new DALFlightLayer();
            DataTable dt = new DataTable();
            dt = dal.showAll();
            dataGridView1.DataSource = dt;
        }
    }
}
