using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment7
{
    [XmlRoot("hotel")]
    public class Hotel
    {
        private Hotel hotel;

        [XmlElement("name")]
        public string HotelName { get; set; }
        [XmlElement("date")]
        public string ConstructionDate { get; set; }
        [XmlElement("address")]
        public string Address { get; set; }
        [XmlElement("staff")]
        public int Staff { get; set; }

        [XmlIgnore]
        public List<Room> Rooms { get; set; }

        [XmlIgnore]
        public List<Customer> Customers { get; set; }

        public Hotel() { }
        public Hotel(string name, string constructionDate, string address, int staff, List<Room> rooms, List<Customer> customers)
        {
            this.HotelName = name;
            this.ConstructionDate = constructionDate;
            this.Address = address;
            this.Staff = staff;
            this.Rooms = rooms;
            this.Customers = customers;
        }

        public Hotel(Hotel hotel)
        {
            this.hotel = hotel;
        }
        public override string ToString()
        {
            string result = "";
            result = "\tHotel: " + this.HotelName + " \n\tDay of Construction: " + this.ConstructionDate + "\n\tAddress: " + this.Address +
                                            "\n\tNumber of staff: " + this.Staff + Environment.NewLine ;
            return result;
        }
    }


}
