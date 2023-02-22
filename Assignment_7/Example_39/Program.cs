using System;
using System.Collections.Generic;
using System.Globalization;
namespace Example_39
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Study\Windows\XML\employee.xml";
            //Here we create a list of employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(100, "Natalie", DateTime.ParseExact("1.1.1995", "d.M.yyyy", CultureInfo.InvariantCulture), 2600.20m));
            employees.Add(new Employee(200, "Nima", DateTime.ParseExact("5.6.1970", "d.M.yyyy", CultureInfo.InvariantCulture), 3800.20m));
            employees.Add(new Employee(300, "Shiva", DateTime.ParseExact("10.12.1980", "d.M.yyyy", CultureInfo.InvariantCulture), 1800.20m));
            XMLSerializer xmlSerializer = new XMLSerializer(filePath);

            //Here we write the whole employee list into the XML file
            Console.WriteLine(xmlSerializer.WriteXML<List<Employee>>(employees));


            //Here we read the content of XML file into a list
            List<Employee> emps = xmlSerializer.ReadXML<List<Employee>>();
            Console.WriteLine("List of all employees in the file:");
            foreach (Employee e in emps)
                Console.WriteLine(e);

            int employeeNumber;
            Console.Write("Employee number? ");
            Int32.TryParse(Console.ReadLine(), out employeeNumber);
            string result = "";
            //Here we print out the list of employees
            foreach (Employee e in emps)
                if (!string.IsNullOrEmpty(result = e.FindEmployee(employeeNumber)))
                    Console.WriteLine("Search result -> " + result);

            Console.ReadLine();
        }
    }
}