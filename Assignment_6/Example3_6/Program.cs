using System;
using System.IO;
namespace Example_36
{
    public class Product
    {
        public static void Main()
        {

            String filePath = @"D:\Study\Windows\test.txt";
            ProductHanlder productHanlder = new ProductHanlder(filePath);
            string[] names = new string[] { "Toothbrush", "Toothpaste", "Soap", "Cream" };
            int[] amounts = new int[] { 100, 50, 25, 40 };
            double[] prices = new double[] { 1.90, 3.90, 2.95, 60.20 };
            for (int index = 0; index < names.Length; index++)
                Console.WriteLine(productHanlder.WriteToFile(names[index], amounts[index], prices[index]));

            //Here we serach items entered by user.
            Console.Write("Please type product name: ");
            string productName = Console.ReadLine();
            Console.WriteLine(productHanlder.ReadFromFile(productName));

            Console.ReadLine();
        }
    }
}