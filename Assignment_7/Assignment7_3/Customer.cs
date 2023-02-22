using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;

namespace Assignment7_2
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public string CustomerName
        {
            get; set;
        }
        [DataMember]
        public string RoomNumber
        {
            get; set;
        }
        [DataMember]
        public string ArrivalDate
        {
            get; set;
        }
        [DataMember]
        public int LengthOfStay
        {
            get; set;
        }
        
        public Customer() { }
        public Customer(string name, string roomNumber, string arrivalDate, int lengthOfStay)
        {
            this.CustomerName = name;
            this.RoomNumber = roomNumber;
            this.ArrivalDate = arrivalDate;
            this.LengthOfStay = lengthOfStay;
        }

        public override string ToString()
        {
            string result = "";
            result = "\n\tCustomer's name: " + CustomerName + "\n\tCustomer's Room: " + RoomNumber +
                      "\n\tArrival date: " + ArrivalDate + "\n\tLength of stay: " + LengthOfStay + " days" + Environment.NewLine;
            return result;
        }
    }
}
