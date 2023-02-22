using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Room
    {
        protected string roomNumber;
        protected string area;
        protected string type;
        protected double pricePerNight;
        protected string description;

        public string RoomNumber { 
            get { return roomNumber; } 
        }
        public string Area
        {
            get { return area; }
        }
        public string Type
        {
            get { return type; }
        }
        public double PricePerNight
        {
            get { return pricePerNight; }
        }
        public string Description
        {
            get { return description; }
        }
        public Room(string roomNumber, string area, string type, double pricePerNight, string description)
        {
            this.roomNumber = roomNumber;
            this.area = area;
            this.type = type;
            this.pricePerNight = pricePerNight;
            this.description = description;
        }
        public override string ToString()
        {
            string result = "";
            result = "\n\tRoom number: " + RoomNumber + "\n\tArea: " + Area + "\n\tRoom type: " + Type +
                                                "\n\tPrice Per Night: " + PricePerNight + "\n\tAddition information: " + Description + Environment.NewLine;
            return result;
        }
        public string FindRoom(string number)
        {
            if (number.Equals(this.roomNumber)) return this.ToString();

            return "";
        }
    }
}
