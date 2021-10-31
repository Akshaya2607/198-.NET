using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBAL;
using System.Data.SqlClient;
using System.Data;

namespace FlightDAL
{
    public class DALFlightLayer
    {
        public DataTable showAll()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-13LEK98\\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from flights", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "flights");
            return ds.Tables["flights"];
        }
        public string InsertFlight(BALFlightLayer bal)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-13LEK98\\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from flights", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "flights");
            DataRow row = ds.Tables["flights"].NewRow();
            row["flightID"] = bal.FlightID;
            row["flightName"] = bal.Flightname;
            row["flightArrival"] = bal.FArrival;
            row["flightDeparture"] = bal.FDepart;
            row["noOfPassengers"] = bal.NoOfPassengers;
            row["crewid"] = bal.CrewID;
            ds.Tables["flights"].Rows.Add(row);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["flights"]);
            string s = "Added";   
            return s;
        }
        public BALFlightLayer FindFlight(int fID)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-13LEK98\\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from flights", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "flights");
            DataRow drowFound = ds.Tables["flights"].Rows.Find(fID);
            BALFlightLayer bal = new BALFlightLayer();
            if (drowFound != null)
            {
                bal.FlightID = fID;
                bal.Flightname= drowFound["flightName"].ToString();
                bal.FArrival= Convert.ToDateTime( drowFound["flightArrival"]);
                bal.FDepart = Convert.ToDateTime(drowFound["flightDeparture"]);
                bal.NoOfPassengers = Convert.ToInt32(drowFound["noOfPassengers"]);
                bal.CrewID= Convert.ToInt32(drowFound["crewid"]);
            }
            return bal;
        }

        public string EditFlight(BALFlightLayer newdata)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-13LEK98\\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from flights", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "flights");
            DataRow drowFound = ds.Tables["flights"].Rows.Find(newdata.FlightID);
            drowFound["flightName"] = newdata.Flightname;
            drowFound["flightArrival"] = newdata.FArrival;
            drowFound["flightDeparture"] = newdata.FDepart;
            drowFound["noOfPassengers"] = newdata.NoOfPassengers;
            drowFound["crewid"] = newdata.CrewID;
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["flights"]);
            string s = "Updated";
            return s;
        }

        public string DeleteFlight(int fid)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-13LEK98\\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from flights", conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataSet ds = new DataSet();
            da.Fill(ds, "flights");
            DataRow drowFound = ds.Tables["flights"].Rows.Find(fid);
            drowFound.Delete();
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["flights"]);
            string s = "Deleted";
            return s;
        }
    }
}
