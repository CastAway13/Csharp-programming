using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_2
{
    class Admin
    {
        public void SearchFlight(Flight[] listFlight, Customer[] listCustomer)
        {
            int userInput1;
            bool check = true;
            Console.Write("Input flight id to search: ");
            userInput1 = Convert.ToInt16(Console.ReadLine());

            foreach (Flight i in listFlight)
            {
                if (i.Searchflight(userInput1))
                {
                    check = false;
                    Console.WriteLine("\nFlight detail:");
                    i.PrintFlight();
                    Console.WriteLine("\n\nCustomers on flight:");
                    foreach (Customer e in listCustomer)
                    {
                        if (e.SearchCustomerById(userInput1))
                        {
                            e.PrintCustomer();
                        }
                    }
                }
            }
            if (check)
            {
                Console.WriteLine("Not found!\n");
            }
        }

        public void SearchCustomer(Customer[] listCustomer, Flight[] listFlight)
        {

            string userInput2;
            Console.Write("\nInput customer's name to search: ");
            userInput2 = Console.ReadLine();
            bool check = true;
            Console.WriteLine();
            foreach (Customer i in listCustomer)
            {
                if (i.SearchCustomerByName(userInput2))
                {
                    check = false;
                    Console.WriteLine("\nCustomer detail:");
                    i.PrintCustomer();
                    foreach (Flight e in listFlight)
                    {
                        if (e.Searchflight(i.GetFlightId()))
                        {
                            Console.WriteLine("\nFlight deatail:");
                            e.PrintFlight();
                        }
                    }
                }
            }
            if (check)
            {
                Console.WriteLine("Not found!");
            }
        }

    }
}
