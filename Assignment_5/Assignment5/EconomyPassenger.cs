using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class EconomyPassenger: Passenger
    {
        protected double luggageWeight;
        public double LuggageWeight
        {
            get { return luggageWeight; }
            set { luggageWeight = value; }
        }
        public EconomyPassenger(int id, string firstName, string surname, string phoneNumber, double weight, ArrayList tickets) : base(id, firstName, surname, phoneNumber, tickets)
        {
            this.luggageWeight = weight;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ID: " + id + "\n");
            result.Append("First name: " + firstName + "\n");
            result.Append("Surname: " + surname + "\n");
            result.Append("Phone number: " + phoneNumber + "\n");
            result.Append("Maximum luggage weight: " + luggageWeight + "\n");

            return result.ToString();
        }
        public override string GetInfo(int searchKey)
        {
            StringBuilder result = new StringBuilder();
            if (searchKey == this.id)
            {
                result.Append(this.ToString());
                result.Append("Tickets: ");
                foreach (Ticket ticket in tickets)
                {
                    result.Append(ticket.TicketId + " ");
                };
                foreach (Ticket ticket in tickets)
                {
                    result.Append("\n\nTicket information: \n");
                    result.Append(ticket.ToString());
                }
            }
            return result.ToString();
        }
    }
}
