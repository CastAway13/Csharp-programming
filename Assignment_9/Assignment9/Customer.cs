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
    class Customer
    {
        [DataMember]
        public string Id{ get; set; }
        [DataMember]
        public string Name{ get; set; }
        [DataMember]
        public string FlightId { get; set; }

        public Customer() { }
        public Customer(string id, string name, string flightId)
        {
            this.Id = id;
            this.Name = name;
            this.FlightId = flightId;
        }

        public bool FindCustomer(string id)
        {
            if (id.Equals(this.Id)) return true;
            return false;
        }
        public bool FindCustomerWithFlightId(string id)
        {
            if (id.Equals(this.FlightId)) return true;
            return false;
        }
        public override string ToString()
        {
            return  Environment.NewLine + Id + "\t\t\t" + Name + "\t\t\t" + FlightId;
        }
    }
}
