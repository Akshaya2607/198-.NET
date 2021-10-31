using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightBAL;
using FlightDAL;
namespace APIFlightBALDAL.Controllers
{
    public class FlightPMController : ApiController
    {
        // GET: api/FlightPM
        public List<BALFlightLayer> Get()
        {
            DALFlightLayer dal = new DALFlightLayer();
            DataTable dt = new DataTable();
            dt = dal.showAll();
            List<BALFlightLayer> list = new List<BALFlightLayer>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BALFlightLayer bal = new BALFlightLayer();
                bal.FlightID = Convert.ToInt32(dt.Rows[i][0]);
                bal.Flightname = dt.Rows[i][1].ToString();
                bal.FArrival = Convert.ToDateTime(dt.Rows[i][2]);
                bal.FDepart = Convert.ToDateTime(dt.Rows[i][3]);
                bal.NoOfPassengers = Convert.ToInt32(dt.Rows[i][4]);
                bal.CrewID = Convert.ToInt32(dt.Rows[i][5]);
                list.Add(bal);
            }
            return list;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/FlightPM/5
        public BALFlightLayer Get(int id)
        {
            BALFlightLayer bal = new BALFlightLayer();
            DALFlightLayer dal = new DALFlightLayer();
            bal = dal.FindFlight(id);
            return bal;

            //return "value";
        }

        // POST: api/FlightPM
        public void Post([FromBody]BALFlightLayer value)
        {
            BALFlightLayer bal = new BALFlightLayer();
            DALFlightLayer dal = new DALFlightLayer();
            bal.Flightname = value.Flightname;
            bal.FArrival = value.FArrival;
            bal.FDepart = value.FDepart;
            bal.NoOfPassengers = value.NoOfPassengers;
            bal.CrewID = value.CrewID;
            string s = dal.InsertFlight(bal);
        }

        // PUT: api/FlightPM/5
        public void Put(int id, [FromBody]BALFlightLayer value)
        {
            BALFlightLayer bal = new BALFlightLayer();
            DALFlightLayer dal = new DALFlightLayer();
            bal.FlightID = value.FlightID;
            bal.Flightname = value.Flightname;
            bal.FArrival = value.FArrival;
            bal.FDepart = value.FDepart;
            bal.NoOfPassengers = value.NoOfPassengers;
            bal.CrewID = value.CrewID;
            dal.EditFlight(bal);
        }

        // DELETE: api/FlightPM/5
        public void Delete(int id)
        {
            DALFlightLayer dal = new DALFlightLayer();
            dal.DeleteFlight(id);

        }
    }
}
