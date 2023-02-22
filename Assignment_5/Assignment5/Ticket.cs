using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Ticket
    {
        private string ticketId;
        private int passengerId;
        private Flight flight;
        private double price;
        private readonly double extraTax;
        public double Price
        {
            get { return price; }
        }
        public int PassengerId
        {
            get { return passengerId; }
            set { passengerId = value; }
        }
        public string TicketId
        {
            get { return ticketId; }
            set { ticketId = value; }
        }
        public Ticket(string ticketId, int passengerId, Flight flight, double price)
        {
            this.ticketId = ticketId;
            this.passengerId = passengerId;
            this.flight = flight;
            this.price = price;
            if (DateTime.Now.DayOfWeek.Equals(DayOfWeek.Saturday) || DateTime.Now.DayOfWeek.Equals(DayOfWeek.Sunday))
                this.extraTax = 0.07f;
            else
                this.extraTax = 0.05f;
        }
        public double GetPrice(string ticketId)
        {
            double result = 0;
            result = this.price + (this.extraTax * this.price);
            return result;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Passenger ID: " + passengerId + "\n");
            result.Append("Ticket ID: " + ticketId + "\n");
            result.Append(flight.ToString());
            return result.ToString();
        }
        public string GetPassengers(ArrayList passengers)
        {
            StringBuilder result = new StringBuilder();
            foreach (Passenger passenger in passengers)
            {
                if (passenger.Id == this.passengerId)
                {
                    result.Append(passenger.ToString());
                    result.Append(this.ToString());
                    result.Append("Price: " + this.Price);
                }
            }
            return result.ToString();
        }
    }
}
