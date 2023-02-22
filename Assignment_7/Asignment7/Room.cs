using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment7
{
    [XmlRoot("room")]
    public class Room
    {
        [XmlElement("number")]
        public string RoomNumber { get; set; }
        [XmlElement("area")]
        public string Area { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
        [XmlElement("price")]
        public double PricePerNight { get; set; }
        [XmlElement("description")]
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

