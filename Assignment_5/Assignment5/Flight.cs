using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Flight
    {
        private string id;
        private string origin;
        private string destination;
        private string date;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public Flight()
        {
        }
        public Flight(string id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }
        public string GetFlight(string searchKey)
        {
            if (searchKey.Equals(this.id))
            {
                return this.ToString();
            }
            return "";
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Flight: " + this.id + "\n");
            result.Append("From " + this.origin + " to " + destination + "\n");
            result.Append("Time: " + this.date + "\n");
            return result.ToString();
        }
    }
}
