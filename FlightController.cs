using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAppDemo.Models;

namespace MVCAppDemo.Controllers
{
    public class FlightController : Controller
    {
        public static List<FlightsModel> flight = new List<FlightsModel>();
        public static List<CrewModel> crew = new List<CrewModel>();

        static FlightController()
        {
            CrewModel c1 = new CrewModel { crewID = 9001, crewName = "Akriti", crewDesg = "Attendant" };
            CrewModel c2 = new CrewModel { crewID = 9002, crewName = "Bill", crewDesg = "Doctor" };
            CrewModel c3 = new CrewModel { crewID = 003, crewName = "Charl", crewDesg = "Captian" };
            CrewModel c4 = new CrewModel { crewID = 9004, crewName = "Della", crewDesg = "Attendant" };
            CrewModel c5 = new CrewModel { crewID = 9006, crewName = "Mayla", crewDesg = "Attendant" };
            CrewModel c6 = new CrewModel { crewID = 001, crewName = "Barly", crewDesg = "Captian" };
            CrewModel c7 = new CrewModel { crewID = 002, crewName = "Sahad", crewDesg = "Captian" };
            CrewModel c8 = new CrewModel { crewID = 9005, crewName = "Fahad", crewDesg = "Attendant" };
            CrewModel c9 = new CrewModel { crewID = 004, crewName = "Ell", crewDesg = "Captian" };
            CrewModel c10 = new CrewModel { crewID = 9010, crewName = "Stella", crewDesg = "Doctor" };

            flCrModel fc = new flCrModel();
            fc.flightID = 1001;
            fc.CrewMembers = new List<CrewModel> { c6, c1, c2 };
            flCrModel fc1 = new flCrModel();
            fc1.flightID = 1002;
            fc1.CrewMembers = new List<CrewModel> { c9, c4, c5, c10 };
            flCrModel fc2 = new flCrModel();
            fc1.flightID = 1003;
            fc1.CrewMembers = new List<CrewModel> { c3, c2, c8 };
            flCrModel fc3 = new flCrModel();
            fc1.flightID = 1004;
            fc1.CrewMembers = new List<CrewModel> { c7, c4, c5, c10 };

            flight.Add(new FlightsModel { flightID = 1001, flightName = "AirBus A360", flightArrival =new DateTime(2021,10,29,08,00,00), flightDeparture = new DateTime(2021, 10, 29, 09, 10, 00), noOfPassengers=100,captainID=001, crewDetails=fc.CrewMembers });
            flight.Add(new FlightsModel { flightID = 1002, flightName = "Dynamics F-11", flightArrival = new DateTime(2021, 11, 01, 14, 45, 15), flightDeparture = new DateTime(2021, 11, 01, 18, 30, 40), noOfPassengers = 200, captainID = 004,crewDetails=fc1.CrewMembers });
            flight.Add(new FlightsModel { flightID = 1003, flightName = "Aerojet General X-8", flightArrival = new DateTime(2021, 10, 31, 06, 15, 00), flightDeparture = new DateTime(2021, 10, 31, 08, 00, 00), noOfPassengers = 150, captainID = 003, crewDetails=fc2.CrewMembers });
            flight.Add(new FlightsModel { flightID = 1004, flightName = "Delta A-55", flightArrival = new DateTime(2021, 11, 05, 23, 08, 15), flightDeparture = new DateTime(2021, 11, 06, 04, 25, 30), noOfPassengers = 200, captainID = 002, crewDetails=fc3.CrewMembers });

           

            

            //crew.Add(new CrewModel { crewID = 9001, crewName = "Akriti", crewDesg = "Attendant" });
            //crew.Add(new CrewModel { crewID = 9002, crewName = "Bill", crewDesg = "Doctor" });
            //crew.Add(new CrewModel { crewID = 9003, crewName = "Charl", crewDesg = "Captian" });
            //crew.Add(new CrewModel { crewID = 9004, crewName = "Della", crewDesg = "Attendant" });
            //crew.Add(new CrewModel { crewID = 9005, crewName = "Fahad", crewDesg = "Attendant" });
            //crew.Add(new CrewModel { crewID = 9006, crewName = "Mayla", crewDesg = "Attendant" });
            //crew.Add(new CrewModel { crewID = 9007, crewName = "Barly", crewDesg = "Captian" });
            //crew.Add(new CrewModel { crewID = 9008, crewName = "Sahad", crewDesg = "Captian" });
            //crew.Add(new CrewModel { crewID = 9009, crewName = "Ell", crewDesg = "Captian" });
            //crew.Add(new CrewModel { crewID = 9010, crewName = "Stella", crewDesg = "Doctor" });
        }

        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListFlights()
        {    
            return View(flight);
        }

      
        public ActionResult Details(int id)
        {
            FlightsModel fm = flight.Find(f => f.flightID == id);
            ViewBag.cd = fm.crewDetails;
            return View(fm);
        }

        public ActionResult AddFlight()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddFlight(FlightsModel f)
        {
            flight.Add(new FlightsModel { flightID = f.flightID, flightName = f.flightName, flightArrival = f.flightArrival, flightDeparture = f.flightDeparture, noOfPassengers = f.noOfPassengers, captainID = f.captainID});
            return RedirectToAction("ListFlights");
        }
        public ActionResult UpdateFlight(int id)
        {
            FlightsModel fm= flight.Find(f => f.flightID == id);
            return View(fm);
        }
        [HttpPost]
        public ActionResult UpdateFlight(int id,FlightsModel data)
        {
            if(ModelState.IsValid)
            {
                FlightsModel fm = flight.Find(f => f.flightID == id);
                
                fm.flightName = data.flightName;
                fm.flightArrival = data.flightArrival;
                fm.flightDeparture = data.flightDeparture;
                fm.noOfPassengers = data.noOfPassengers;
                fm.captainID = data.captainID;
                return RedirectToAction("ListFlights");
            }
            return View(data);
        }
        public ActionResult CancelFlight(int id)
        {
            FlightsModel fm = flight.Find(f => f.flightID == id);
            return View(fm);
        }
        [HttpPost]
        public ActionResult CancelFlight(int id, FlightsModel data)
        {
            FlightsModel fm = flight.Find(f => f.flightID == id);
            flight.Remove(fm);
            return RedirectToAction("ListFlights");
        }
    }
}