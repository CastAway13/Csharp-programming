using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Customer
    {
        private string name;
        private int id;
        private int flightId;

        public Customer(string name, int id, int flightId)
        {
            this.name = name;
            this.id = id;
            this.flightId = flightId;
        }

        public int GetFlightId()
        {
            return flightId;
        }

        public bool SearchCustomerByName(string name)
        {
            return (name.Equals(this.name));
        }
        public bool SearchCustomerById(int flightId)
        {
            return (flightId == this.flightId);
        }

        public void PrintCustomer()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Flight id: " + flightId);
        }
    }
}
