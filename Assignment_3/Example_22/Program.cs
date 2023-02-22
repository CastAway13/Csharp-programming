using System;
namespace Example_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ShopName = "Food Shop";
            Console.WriteLine(product.ShopName);
            //Here we get the current date and time and print it in the specified way.
            Console.WriteLine("Current date and time: " + Product.currentDateTime.ToString("yyyy-MM-dd HH.mm.ss"));
            Console.WriteLine("Weekday:" + Product.weekDay);
            Console.WriteLine("Discount percentage:" + Product.discountPercentage);
            //
            product[0] = new Product("Peach", 100, 3.4567f);
            product[1] = new Product("Pommegranite", 1001, 22.55f);
            product[2] = new Product("Strawberry", 1002, 6.65f);
            product[3] = new Product("Fig", 1002, 19.65f);
            Console.WriteLine("List of all available product:");
            for (int i = 0; i < product.Count(); i++)
                Console.WriteLine(product[i]);
            int pID = 1002;
            Console.WriteLine("Result of searching product with id=" + pID);
            Console.WriteLine(product.SearchProduct(pID));

            Console.ReadLine();
        }
    }
}