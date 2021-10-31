using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBAL
{
    public class BALFlightLayer
    {
        int _flightid;
        public int FlightID
        {
            get
            {
                return _flightid;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Flight id cannot be null or zero");
                }
                else
                {
                    _flightid = value;
                }
            }
        }

        string _name;
        public string Flightname {
            get { return _name; }
            set {
                if (value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name can't be blank or null");
                }
            }
        }
        public DateTime FArrival { get; set; }
        public DateTime FDepart { get; set; }

        int _count;
        public int NoOfPassengers { 
            get { return _count; } 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Passenger Count cannot be null or zero");
                }
                else
                {
                    _count = value;
                }
            }
        }

        int _crewid;
        public int CrewID { get { return _crewid; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Crew ID cannot be null or zero");
                }
                else
                {
                    _crewid = value;
                }
            }
        }

    }
}
