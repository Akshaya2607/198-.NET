using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCAppDemo.Models
{
    public class FlightsModel
    {
        public int flightID { get; set; }
        public string flightName { get; set; }
        [DataType("datetime-local")]
        public DateTime flightArrival { get; set; }

        [DataType("datetime-local")]
        public DateTime flightDeparture { get; set; }
        public int noOfPassengers { get; set; }
        public int captainID { get; set; }
        public List<CrewModel> crewDetails { get; set; }

    }
}