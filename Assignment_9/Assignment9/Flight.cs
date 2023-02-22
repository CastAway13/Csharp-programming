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

namespace Assignment9
{
    [DataContract]
    class Flight
    {
        [DataMember]
        public string Id
        { get; set; }
        [DataMember]
        public string AirlineCompany
        { get; set; }
        [DataMember]
        public string Origin
        { get; set; }
        [DataMember]
        public string Destination
        { get; set; }
        [DataMember]
        public string Date
        { get; set; }

        public Flight() { }
        public Flight(string id, string airlineCompany, string origin, string destination, string date)
        {
            this.Id = id;
            this.AirlineCompany = airlineCompany;
            this.Origin = origin;
            this.Destination = destination;
            this.Date = date;
        }
        public bool FindFlight (string id)
        {
            if (id.Equals(this.Id)) return true;
            return false;
        }
        public override string ToString()
        {
            return Environment.NewLine + Id + "\t\t" + AirlineCompany + "\t\t" + Origin + "\t\t" + Destination + "\t\t" + Date;
        }
    }
}
