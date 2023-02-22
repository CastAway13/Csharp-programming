using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Flight
    {
        private int id;
        public int Id
        {
            get { return id; }
            set {  this.id = value; }
        }

        private string origin;
        public string Origin
        {
            get { return origin; }
            set { this.origin = value; }
        }

        private string destination;
        public string Destination
        {
            get { return destination; }
            set { this.destination = value; }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set { this.date = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public Flight(int id, string origin, string destination, string date, double price) {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.price = price;
        }

        public string FindFlight(int searchId)
        {
            if(searchId == this.id)
            {
                return this.ToString();
                
            }
            return "";
        }
        public override string ToString()
        {
            string s = "Flight ID: " + id + "\nOrigin: " + origin + "\nDestination: " + destination +
                        "\nDate: " + date + "\nPrice: " + price + "$";
            return s;
        }
    }
}
