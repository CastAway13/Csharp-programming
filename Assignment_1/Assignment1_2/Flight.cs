using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Flight
    {
        private int id;
        private string origin;
        private string destination;
        private string date;

        public Flight (int id, string origin, string destination, string date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public int GetId()
        {
            return id;
        }

        public bool Searchflight(int searchKey)
        {
            return (this.id == searchKey);
        }
        public void PrintFlight()
        {
            Console.WriteLine("\nID: " + id);
            Console.WriteLine("Origin: " + origin);
            Console.WriteLine("Destination: " + destination);
            Console.WriteLine("Date: " + date);
        }
    }
}
