using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathHotel = @"D:\Study\Windows\hotel.txt";
            string filePathRoom = @"D:\Study\Windows\room.txt";
            string filePathCustomer = @"D:\Study\Windows\customer.txt";

            Room tulip = new Room("A01", "South", "Single", 20,"Small room suitable for 1 person.");
            Room lily = new Room("A11", "North", "Double", 40, "Big room for couple.");
            Room blossom = new Room("B01", "East", "President", 150, "Luxury experience room.");

            ArrayList rooms = new ArrayList { tulip, lily, blossom };

            Customer Cus1 = new Customer("Trung", "401 Voyrinkatu", "14/02", 1);
            Customer Cus2 = new Customer("Viet", "52 Handel", "14/03", 3);
            Customer Cus3 = new Customer("David", "50 Palosarentie", "28/02", 2);

            ArrayList customers = new ArrayList { Cus1, Cus2, Cus3 };

            Hotel hotel = new Hotel("Lion Head", "18-03-1999", "Korsholm 89,Vaasa", 50, rooms, customers);

            hotel.WriteToFileHotel(filePathHotel);
            hotel.WriteToFileRoom(filePathRoom);
            hotel.WriteToFileCustomer(filePathCustomer);

            Console.WriteLine("\n-----Read information from file-----");
            Console.WriteLine("\nHotel information: ");
            Console.WriteLine(hotel.ReadFromFileHotel(filePathHotel));

            Console.WriteLine("Room information:");
            Console.WriteLine(hotel.ReadFromFileRoom(filePathRoom));

            Console.WriteLine("Customer information:");
            Console.WriteLine(hotel.ReadFromFileCustomer(filePathCustomer));
            

            string roomSearch;
            Console.Write("Enter the room number to search:");
            roomSearch = Console.ReadLine();
            foreach(Room room in rooms)
            {
                Console.WriteLine(room.FindRoom(roomSearch));
            }

            string customerSearch;
            Console.Write("Enter the customer name to search:");
            customerSearch = Console.ReadLine();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.FindCustomer(customerSearch));
            }

            string hotelSearch;
            Console.Write("Enter the hotel name to search:");
            hotelSearch = Console.ReadLine();
            Console.WriteLine(hotel.FindHotel(hotelSearch));

            Console.ReadLine();
        }
    }
}
