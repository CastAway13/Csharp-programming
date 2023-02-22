using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment7
{
    [XmlRoot("customer")]
    public class Customer
    {
        [XmlElement("name")]
        public string CustomerName
        {
            get; set;
        }
        [XmlElement("room")]
        public string RoomNumber
        {
            get; set;
        }
        [XmlElement("arrival")]
        public string ArrivalDate
        {
            get; set;
        }
        [XmlElement("length")]
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
