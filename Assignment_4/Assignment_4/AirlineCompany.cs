using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public delegate string FindFlightDelegate(int id);
 
    class AirlineCompany
    {
        private readonly string airlineName;
        public string AirlineName
        {
            get { return airlineName; }
        }
        public AirlineCompany(string airlineName)
        {
            this.airlineName = airlineName;
        }
        private List<Flight> flights = new List<Flight>();
        public Flight this[int index]
        {
            set
            {
                flights.Insert(index, value);
            }
            get
            {
                return flights[index];
            }
        }
        public int Count()
        {
            return flights.Count;
        }
        public string FindFLight(int flightId)
        {
            string result = "";
            foreach (Flight f in flights)
            {
                result += f.FindFlight(flightId);
            }
            return result;
        }

        public string ReturnFlightGreaterThanPrice(FindFlightDelegate findFlightDelegate, double price)
        {
            string result = "";
            foreach (Flight f in flights)
            {
                if (price < f.Price)
                {
                    result += findFlightDelegate(f.Id);
                }
            }
            return result;
        }
        public void FindFlightWithLessPrice(Action<Flight, double> action, Flight flight, double price)
        {
            action(flight, price);
        }
        public string FindFlightWhichGreaterThan250(Predicate<double> predicate)
        {
            string result = "";
            foreach (Flight f in flights)
            {
                if (predicate(f.Price))
                {
                    result += f;
                    break;
                }
            }
            return result;
        }
    }
    
}