using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Serialization;

namespace Assignment7_2
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public string RoomNumber { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public double PricePerNight { get; set; }
        [DataMember]
        public string Description { get; set; }
        public Room() { }
        public Room(string roomNumber, string area, string type, double pricePerNight, string description)
        {
            this.RoomNumber = roomNumber;
            this.Area = area;
            this.Type = type;
            this.PricePerNight = pricePerNight;
            this.Description = description;
        }
        public override string ToString()
        {
            string result = "";
            result = "\n\tRoom number: " + RoomNumber + "\n\tArea: " + Area + "\n\tRoom type: " + Type +
                                                "\n\tPrice Per Night: " + PricePerNight + "\n\tAddition information: " + Description + Environment.NewLine;
            return result;
        }
    }
}

