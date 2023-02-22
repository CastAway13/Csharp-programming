using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            TextAnalyzer text = new TextAnalyzer();
            text.InitializeText(out s);
            Console.WriteLine("Initialize text: " + text.GetText() + "\n");
            Console.WriteLine("Content of the collection: ");
            SortedList<char, int> list = text.AddToCollection();
            foreach (var kvp in list)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            Console.ReadLine();
        }
    }
}
