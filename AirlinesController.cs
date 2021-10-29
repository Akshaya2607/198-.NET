using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using WebAPIDemo.Models;
namespace WebAPIDemo.Controllers
{
    public class AirlinesController : ApiController
    {
        // GET: api/Airlines
        public List<FlightsModel> GetFlightList()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-13LEK98\SQLEXPRESS;Initial Catalog=FlightDB;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select *from flights",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<FlightsModel> flightlist = new List<FlightsModel>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                FlightsModel flight = new FlightsModel();
                flight.flightID = Convert.ToInt32( ds.Tables[0].Rows[i][0]);
                flight.flightName = ds.Tables[0].Rows[i][1].ToString();
                flight.flightArrival = Convert.ToDateTime( ds.Tables[0].Rows[i][2]);
                flight.flightDeparture= Convert.ToDateTime(ds.Tables[0].Rows[i][3]);
                flight.noOfPassengers= Convert.ToInt32(ds.Tables[0].Rows[i][4]);
                //flight.captainID= Convert.ToInt32(ds.Tables[0].Rows[i][5]);
                flightlist.Add(flight);
            }
            return flightlist;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Airlines/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Airlines
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Airlines/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Airlines/5
        public void Delete(int id)
        {
        }
    }
}
