using System;
using System.Collections.Generic;
using System.Globalization;
namespace Example_310
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Study\Windows\json\json.txt";
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(100, "Natalie", DateTime.ParseExact("1.1.1995", "d.M.yyyy", CultureInfo.InvariantCulture), 3600.20m));
            employees.Add(new Employee(200, "Nima", DateTime.ParseExact("5.6.1970", "d.M.yyyy", CultureInfo.InvariantCulture), 1500.20m));
            employees.Add(new Employee(300, "Shiva", DateTime.ParseExact("10.12.1980", "d.M.yyyy", CultureInfo.InvariantCulture), 5600.20m));
            JSONSerializer jsonSerializer = new JSONSerializer(filePath);
            //Here we write the list of employees to JSON file
            Console.WriteLine(jsonSerializer.WriteToJSONFile(employees));
            //Here we read the list of employees from JSON file.
            List<Employee> empObjects = jsonSerializer.ReadFromJSONFile();
            //Here we print out the list of employees.
            foreach (Employee e in empObjects)
                Console.WriteLine(e);
            int employeeNumber;
            Console.Write("Employee number? ");
            string result = "";
            Int32.TryParse(Console.ReadLine(), out employeeNumber);
            //Here we print out the search result of employees
            foreach (Employee e in empObjects)
                if (!string.IsNullOrEmpty(result = e.FindEmployee(employeeNumber)))
                    Console.WriteLine("Search result -> " + result);

            //Here is a dynamic way for reading data in a general form
            //dynamic empObject = jsSerializer.Deserialize<dynamic>(jsonData);
            //int employeeNumber= empObject["EmployeeNumber"];
            //string employeeName = empObject["EmployeeName"];
            //decimal salary = empObject["Salary"];
            //DateTime birthday;
            //DateTime.TryParse(empObject["Birthday"], out birthday);
            //   Console.WriteLine("empObject: " + employeeNumber + " " + employeeName + " " + birthDay + " " + salary)   ;
            Console.ReadLine();
        }
    }
}