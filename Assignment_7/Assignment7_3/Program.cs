using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePathHotel = @"D:\Study\Windows\json\hotel.txt";
            string filePathRoom = @"D:\Study\Windows\json\room.txt";
            string filePathCustomer = @"D:\Study\Windows\json\customer.txt";

            Room tulip = new Room("A01", "South", "Single", 20, "Small room suitable for 1 person.");
            Room lily = new Room("A11", "North", "Double", 40, "Big room for couple.");
            Room blossom = new Room("B01", "East", "President", 150, "Luxury experience room.");

            List<Room> rooms = new List<Room> { tulip, lily, blossom };

            Customer Cus1 = new Customer("Trung", "401 Voyrinkatu", "14/02", 1);
            Customer Cus2 = new Customer("Viet", "52 Handel", "14/03", 3);
            Customer Cus3 = new Customer("David", "50 Palosarentie", "28/02", 2);

            List<Customer> customers = new List<Customer> { Cus1, Cus2, Cus3 };

            Hotel hotel = new Hotel("Lion Head", "18-03-1999", "Korsholm 89, Vaasa", 50, rooms, customers);


            JSONSerializer jsonSerializerHotel = new JSONSerializer(filePathHotel);
            Console.WriteLine(jsonSerializerHotel.WriteToJSONFileHotel(hotel));

            JSONSerializer jsonSerializerRoom = new JSONSerializer(filePathRoom);
            Console.WriteLine(jsonSerializerRoom.WriteToJSONFileRoom(rooms));

            JSONSerializer jsonSerializerCustomer = new JSONSerializer(filePathCustomer);
            Console.WriteLine(jsonSerializerCustomer.WriteToJSONFileCustomer(customers));


            Console.WriteLine("\n-----Read information from file-----");
            Console.WriteLine("\nHotel information: ");
            Hotel hotelInformation = new Hotel();
            hotelInformation = jsonSerializerHotel.ReadHotelFromJSONFile();
            Console.WriteLine(hotelInformation);

            Console.WriteLine("Room information:");
            List<Room> roomList = new List<Room>();
            roomList = jsonSerializerRoom.ReadRoomFromJSONFile();
            foreach (Room room in roomList)
            {
                Console.WriteLine(room);
            }

            Console.WriteLine("Customer information:");
            List<Customer> customerList = new List<Customer>();
            customerList = jsonSerializerCustomer.ReadCustomerFromJSONFile();
            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }
            Console.ReadLine();
        }
    }
}
