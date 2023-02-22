//This is Program.cs file
using System;
namespace Example_35
{
    public class Program
    {
        public static void Main()
        {
            //Here we define file path. We use @ before strings to void having to
            //escape special characters
            string filePath = @"D:\Study\Windows\products.dat";
            ProductHanlder productHanlder = new ProductHanlder(filePath);
            //Here we define a group of products
            string[] productNames = new string[] { "Brush", "Comb", "Soap" };
            int[] productAmounts = new int[] { 10, 5, 20 };
            double[] productPrices = new double[] { 1.80, 2.67, 3.45 };
            string result = "";
            for (int i = 0; i < productNames.Length; i++)
            {
                result += productHanlder.WriteToFile(productNames[i], productAmounts[i], productPrices[i]) + Environment.NewLine;
            }
            Console.WriteLine("Results of writing data to the file: " + Environment.NewLine + result);
            //Here we serach items entered by user.
            Console.Write("Please type product name: ");
            string productName = Console.ReadLine();
            result = productHanlder.ReadFromFile(productName);
            Console.WriteLine("Results of searching " + productName + " from file: " + Environment.NewLine + result);

            Console.ReadLine();
        }
    }
}
