using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineCompany vn = new AirlineCompany("Pacific");
            Console.WriteLine("Airline: " + vn.AirlineName);
            vn[0] = new Flight(1, "Viet Nam", "Finland", "24/11", 269.9);
            vn[1] = new Flight(2, "Finland", "Singapore", "25/11", 109.9);
            vn[2] = new Flight(3, "Singapore", "Finland", "26/11", 129.9);
            vn[3] = new Flight(4, "Holland", "Germany", "27/11", 69.9);
            FindFlightDelegate byPrice = new FindFlightDelegate(vn.FindFLight);
            Action<Flight, double> action = (flight, price) => Console.WriteLine(price > flight.Price ? flight.ToString() : null);

            Predicate<double> predicate = (price) => (price > 250);
            bool flag = true;

            while (flag)
            {
                int choice = 0;
                Console.WriteLine("\nPlease choose option below:");
                Console.WriteLine("1. Print all available flights");
                Console.WriteLine("2. Search flight");
                Console.WriteLine("3. Display the flight have greater price than input price");
                Console.WriteLine("4. Compare input price with chosen flight");
                Console.WriteLine("5. Print all flights have price greater than 250");
                Console.WriteLine("6. Exit");
                choice = Convert.ToInt16(Console.ReadLine());
                int userInput;
                double userInput1;
                string result = "";

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("List of all available Flight:");
                        for (int i = 0; i < 4; i++)
                            Console.WriteLine(vn[i] + "\n");
                        break;
                    case 2:
                        result = "";
                        Console.Write("Input flight id to search: ");
                        userInput = Convert.ToInt16(Console.ReadLine());
                        result = vn.FindFLight(userInput);

                        if (string.IsNullOrEmpty(result))
                        {
                            Console.WriteLine("Flight not found!");
                        }
                        else
                            Console.WriteLine("\n" + result);
                        break;
                    case 3:
                        result = "";

                        Console.Write("Input the price:");
                        userInput1 = Convert.ToDouble(Console.ReadLine());
                        result = vn.ReturnFlightGreaterThanPrice(byPrice, userInput1);

                        if (string.IsNullOrEmpty(result))
                        {
                            Console.WriteLine("Flight not found!");
                        }
                        else
                            Console.WriteLine("\n" + result);
                        break;
                    case 4:
                        result = "";

                        Console.Write("Input the price: ");
                        userInput1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Input Flight's id: ");
                        userInput = Convert.ToInt32(Console.ReadLine());

                        vn.FindFlightWithLessPrice(action, vn[userInput-1], userInput1);
                        break;
                    case 5:
                        Console.WriteLine(vn.FindFlightWhichGreaterThan250(predicate));
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}
