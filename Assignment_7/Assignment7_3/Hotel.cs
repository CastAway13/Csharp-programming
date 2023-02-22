using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Assignment7_2
{
    [DataContract]
    public class Hotel
    {
        private Hotel hotel;

        [DataMember]
        public string HotelName { get; set; }
        [DataMember]
        public string ConstructionDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Staff { get; set; }

        [JsonIgnore]
        public List<Room> Rooms { get; set; }

        [JsonIgnore]
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
