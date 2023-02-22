using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Concert ticket1 = new Concert("Pop", "Central Hall", "1/11", "11pm", 20);
            Concert ticket2 = new Concert("Book", "Library", "2/11", "11am", 10);
            Concert ticket3 = new Concert("Game", "Central Hall", "3/11", "10am", 15);
            Concert ticket4 = new Concert("Rock", "Stadium", "4/11", "10pm", 50);
            Concert ticket5 = new Concert("Country", "Central Hall", "5/11", "9pm", 30);

            

            Hashtable concerts = new Hashtable();
            concerts.Add(ticket1.GetTitle(), ticket1);
            concerts.Add(ticket2.GetTitle(), ticket2);
            concerts.Add(ticket3.GetTitle(), ticket3);
            concerts.Add(ticket4.GetTitle(), ticket4);
            concerts.Add(ticket5.GetTitle(), ticket5);

            Console.WriteLine("Price of Pop concert before ++: " + ticket1.GetPrice() + "$");
            ticket1++;
            Console.WriteLine("Price of Pop concert after ++: " + ticket1.GetPrice() + "$");

            Console.WriteLine("Price of Book concert before --: " + ticket2.GetPrice() + "$");
            ticket2--;
            Console.WriteLine("Price of Book concert after --: " + ticket2.GetPrice() + "$");

            Console.WriteLine("Ticket 1 is cheaper than ticket 2: " + (ticket1 < ticket2));
            Console.WriteLine("Ticket 2 is cheaper than ticket 1: " + (ticket2 < ticket1) + "\n");

            Console.WriteLine("The content of the Hashtable:\n");
            foreach (DictionaryEntry concert in concerts)
            {
                Console.WriteLine("Key: \n\t" + concert.Key + "\nValue:\n" + concert.Value);
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
