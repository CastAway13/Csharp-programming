using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class FirstClassPassenger : EconomyPassenger
    {
        protected double bonus;
        protected string menu;

        public FirstClassPassenger(int id, string firstName, string surname, string phoneNumber, double weight, ArrayList tickets, string menu) : base(id, firstName, surname, phoneNumber, weight, tickets)
        {
            foreach (Ticket ticket in tickets)
            {
                this.bonus += ticket.Price * 0.02;
            }
            this.menu = menu;
        }

        public double GetBonus
        {
            get
            {
                return bonus;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ID: " + id + "\n");
            result.Append("First name: " + firstName + "\n");
            result.Append("Surname: " + surname + "\n");
            result.Append("Phone number: " + phoneNumber + "\n");
            result.Append("Maximum luggage weight: " + luggageWeight + "\n");
            result.Append("Meal: " + menu + "\n");
            result.Append("Bonus: " + bonus + "\n");

            return result.ToString();
        }
        public override string GetInfo(int searchKey)
        {
            StringBuilder result = new StringBuilder();
            if (this.id == searchKey)
            {
                result.Append(this.ToString());
                result.Append("Tickets: ");
                foreach (Ticket ticket in tickets)
                {
                    result.Append(ticket.TicketId + " ");
                }
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
