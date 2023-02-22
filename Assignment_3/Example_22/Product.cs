//This is the content of Product.cs file
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
namespace Example_22
{
    class Product
    {
        string name;
        int id;
        float unitPrice;
        string shopName;
        //Here we define readonly field discountPercentage
        public static readonly float discountPercentage;
        //Here we define readonly field currentDateTime
        public static readonly DateTime currentDateTime;
        //Here we define readonly field weekDay
        public static readonly DayOfWeek weekDay;
        //Here we define a pattern for words, which consists ot 3 to 10 letters.
        //\d is equivalent to [a-zA-Z0-9_]. \s is any whitespace character.
        string namePattern = @"^\w{2}[\w\s]{1,8}$";
        //Here we define a pattern for numbers between 1000 and 9999.
        string idPattern = @"[1-9]\d{3}";
        //Here we define a pattern for decimal numbers between 1.0-99.99
        string pricePattern = @"^[1-9]\d?[.,]\d{1,2}$";
        Regex nameRegEx, idRegEx, priceRegEx;
        //Here we define the static constructor, where we initialize the readonly field
        static Product()
        {
            //Here we would get the current date and time
            //DateTime now = DateTime.Now;
            //We can define a new DateTime object in the following way:
            //DateTime(year, month, day, hour, minute, second)
            //DateTime dateTime = new DateTime(2014, 9, 20, 8, 30, 15);
            //Here we define a date and time
            string dateTimePattern = "dd.MM.yyyy HH:mm";
            string dateTimeText = "10.09.2021 08:15";
            //Here we try to parse the given date time text according to the given pattern
            //and set dateTime variable.
            if (!DateTime.TryParseExact(dateTimeText, dateTimePattern, null,
            DateTimeStyles.None, out currentDateTime))
                currentDateTime = DateTime.Now;
            
            weekDay = currentDateTime.DayOfWeek;
            if (weekDay == DayOfWeek.Friday || weekDay == DayOfWeek.Saturday)
                discountPercentage = 5;
            else if (weekDay == DayOfWeek.Sunday)
                discountPercentage = 15;
            else
                discountPercentage = 0;
        }
        //Here we define the default constructor
        public Product()
        {
            //Here we call InitRegEx() method.
            InitRegEx();
        }
        //Here we define constructor for initialising all attributes
        public Product(string name, int id, float unitPrice)
        {
            //Here we call InitRegEx() method.
            InitRegEx();
            if (nameRegEx.IsMatch(name))
                this.name = name;
            else
                this.name = "Unknown";
            //Here we initialise id with the given value if it matches the specified pattern.
            //Otherwise it will be initialised to 0 automathically.
            if (idRegEx.IsMatch(id.ToString()))
                this.id = id;
            //Here we initialise unitPrice with the given value if it matches the specified pattern.
            //Otherwise it will be initialised to 0 automathically.
            if (priceRegEx.IsMatch(unitPrice.ToString()))
                this.unitPrice = (1 - (discountPercentage / 100)) * unitPrice;
        }
        //We put Regex initializations under InitRegEx() method.
        public void InitRegEx()
        {
            nameRegEx = new Regex(namePattern);
            idRegEx = new Regex(idPattern);
            priceRegEx = new Regex(pricePattern);
        }
        //Here we define ShopName property
        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                if (nameRegEx.IsMatch(value))
                    shopName = value;
                else
                    shopName = "Unknown";
            }
        }
        //Here we define ID property
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (idRegEx.IsMatch(id.ToString()))
                    id = value;
            }
        }
        //Here we define an array of Product objects,
        //which we use for saving .
        private List<Product> products = new List<Product>();
        //Here we define the indexer for the class. Notice that
        //here the indexer returns objects of type Product.
        public Product this[int index]
        {
            set
            {
                products.Insert(index, value);
            }
            get
            {
                return products[index];
            }
        }
        public int Count()
        {
            return products.Count;
        }
        //This method is used for searching products from the product collection.
        public string SearchProduct(int id)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Product p in products)
            {
                if (p.id == id)
                    stringBuilder.Append(p.ToString() + Environment.NewLine);
            }
            return stringBuilder.ToString();
        }
        //Here we define ToString() method for the class.
        public override string ToString()
        {
            return name + "-->" + ID + " " + unitPrice;
        }
    }
}