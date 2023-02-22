using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany vn = new AirlineCompany("Pacific");
            Console.WriteLine("Airline: " + vn.AirlineName);
            vn[0] = new Flight(1, "Viet Nam", "Finland", "24/11", 169.9);
            vn[1] = new Flight(2, "Finland", "Singapore", "25/11", 109.9);
            vn[2] = new Flight(3, "Singapore", "Finland", "26/11", 129.9);
            vn[3] = new Flight(4, "Holland", "Germany", "27/11", 69.9);
            bool flag = true;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Print all available flights");
                Console.WriteLine("2. Search flight");
                Console.WriteLine("3. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("List of all available Flight:");
                        for (int i = 0; i < 4; i++)
                            Console.WriteLine(vn[i] + "\n");
                        break;
                    case 2:
                        int userInput;
                        string result = "";

                        Console.Write("Input flight id to search: ");
                        userInput = Convert.ToInt16(Console.ReadLine());

                        result = vn.FindFLight(userInput) ;

                        if (string.IsNullOrEmpty(result))
                        {
                            Console.WriteLine("Flight not found!");
                        }
                        else
                            Console.WriteLine("\n" + result);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
