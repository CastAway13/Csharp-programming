using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Customer
    {
        protected string name;
        protected string roomNumber;
        protected string arrivalDate;
        protected int lengthOfStay;

        public string Name
        {
            get { return name; }
        }
        public string RoomNumber
        {
            get { return roomNumber; }
        }
        public string ArrivalDate
        {
            get { return arrivalDate; }
        }
        public int LengthOfStay
        {
            get { return lengthOfStay; }
        }
        public Customer(string name, string roomNumber, string arrivalDate, int lengthOfStay)
        {
            this.name = name;
            this.roomNumber = roomNumber;
            this.arrivalDate = arrivalDate;
            this.lengthOfStay = lengthOfStay;
        }
        public override string ToString()
        {
            string result = "";
            result = "\n\tCustomer's name: " + name + "\n\tCustomer's Room: " + RoomNumber +
                      "\n\tArrival date: " + ArrivalDate + "\n\tLength of stay: " + LengthOfStay + " days" + Environment.NewLine;
            return result;
        }
        public string FindCustomer(string Name)
        {
            if (Name.Equals(this.name)) return this.ToString();
            else return "";
        }
    }
}
