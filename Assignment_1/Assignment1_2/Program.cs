using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Customer[] listCustomer = { new Customer("thien", 1, 1), new Customer("trung", 2, 1), 
                                           new Customer("Eddie", 3, 2), new Customer("John", 4, 2), 
                                            new Customer("Lincoln", 5, 3) };
            Flight[] listFlight = { new Flight(1, "Finland", "Viet Nam", "24/11"), new Flight(2, "Finland", "Russia", "25/11"), 
                                    new Flight(3, "Finland", "China", "26/11")};
            int choice=0;
            bool flag = true;
            
            while (flag) {
                Console.WriteLine("\nPlease choose option to search:");
                Console.WriteLine("1. Search flight");
                Console.WriteLine("2. Search customer");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        admin.SearchFlight(listFlight, listCustomer);
                        break;
                    case 2:
                        admin.SearchCustomer(listCustomer, listFlight);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}