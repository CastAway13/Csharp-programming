using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight HELtoSG = new Flight("HT01", "Finland", "Singapore", "1/12");
            Flight SGtoVN = new Flight("HT02", "Singapore", "Viet Nam", "2/12");
            Flight VNtoHEL = new Flight("HB01", "Viet Nam", "Finland", "5/12");


            Ticket ticketHELtoSG1 = new Ticket("SG1", 1, HELtoSG, 200);
            Ticket ticketHELtoSG2 = new Ticket("SG2", 2, HELtoSG, 400);

            Ticket ticketSGtoVN1 = new Ticket("VN1", 1, SGtoVN, 100);
            Ticket ticketSGtoVN2 = new Ticket("VN2", 2, VNtoHEL, 200);

            Ticket ticketVNtoHEL1 = new Ticket("FI1", 3, VNtoHEL, 2000);
            Ticket ticketVNtoHEL2 = new Ticket("FI2", 2, VNtoHEL, 1500);

            ArrayList tickets1 = new ArrayList
            {
                ticketHELtoSG1,
                ticketSGtoVN1
            };

            ArrayList tickets2 = new ArrayList
            {
                ticketHELtoSG2,
                ticketSGtoVN2
            };

            ArrayList tickets3 = new ArrayList
            {
                ticketVNtoHEL1
            };

            Passenger passenger1 = new Passenger(1, "Trung", "Vu", "01234", tickets1);
            Passenger passenger2 = new EconomyPassenger(2, "Ngoc", "Le", "014", 23, tickets2);
            Passenger passenger3 = new FirstClassPassenger(3, "Thien", "Bach", "05678", 46, tickets3, "beefsteak & wine");

            ArrayList passengers = new ArrayList
            {
                passenger1,
                passenger2,
                passenger3
            };

            Console.WriteLine("---------- Check passenger by ticket ---------");
            Console.WriteLine(ticketVNtoHEL1.GetPassengers(passengers));§
            Console.WriteLine();
            Console.WriteLine(ticketHELtoSG1.GetPassengers(passengers));
            Console.WriteLine();

            Console.WriteLine("---------- Get passenger ---------");
            Console.WriteLine(passenger1.GetInfo(1));

            Console.WriteLine("---------- Get economy passenger ---------");
            Console.WriteLine(passenger2.GetInfo(2));

            Console.WriteLine("---------- Get first class passenger ---------");
            Console.WriteLine(passenger3.GetInfo(3));
            Console.ReadLine();
        }
    }
}
