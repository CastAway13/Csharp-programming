using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Passenger
    {
        protected int id;
        protected string firstName;
        protected string surname;
        protected string phoneNumber;
        protected ArrayList tickets ;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Passenger(int id, string firstName, string surname, string phoneNumber, ArrayList tickets)
        {
            this.id = id;
            this.firstName = firstName;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.tickets = tickets;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ID: " + id + "\n");
            result.Append("First name: " + firstName + "\n");
            result.Append("Surname: " + surname + "\n");
            result.Append("Phone number: " + phoneNumber + "\n");

            return result.ToString();
        }
        public virtual string GetInfo(int searchKey)
        {
            StringBuilder result = new StringBuilder();
            if (searchKey == this.id)
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
