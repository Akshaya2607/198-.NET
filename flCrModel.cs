using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppDemo.Models
{
    public class flCrModel
    {
        public int flightID { get; set; }
        public List<CrewModel> CrewMembers { get; set; }
    }
}