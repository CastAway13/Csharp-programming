//This is Employee.cs file
using System;
using System.Xml;
using System.Xml.Serialization;
namespace Example_39
{
    //Here we give a custome name to the root element of the class.
    //Otherwise the name of the root will be the same as the name of
    //the class.
    [XmlRoot("employee")]
    public class Employee
    {
        //Here we define a custom element name in the XML file.
        [XmlElement("name")]
        public string EmployeeName { get; set; }
        //Here we define a custom element name in the XML file.
        [XmlElement("salary")]
        public decimal Salary { get; set; }
        //Here we define this property as attribute
        [XmlAttribute("id")]
        public int EmployeeNumber { get; set; }
        //Here we inform that birthday should not be put in XML file
        [XmlIgnore]
        public DateTime Birthday { get; set; }
        //The class must have a parameterless constructor to make
        //sure that its objects can be serlialized az XML.
        public Employee() { }
        //Here we define the constructor
        public Employee(int employeeNumber, string employeeName, DateTime birthday, decimal salary)
        {
            this.EmployeeNumber = employeeNumber;
            this.EmployeeName = employeeName;
            this.Salary = salary;
            this.Birthday = birthday;
        }
        public string FindEmployee(int employeeNumber)
        {
            if (this.EmployeeNumber == employeeNumber)
                return this.ToString();
            return "";
        }

        //Here we define the ToString method for the class
        public override string ToString()
        {
            return EmployeeNumber + " " + EmployeeName + " " + Salary;
        }
    }
}