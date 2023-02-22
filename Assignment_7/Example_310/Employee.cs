using System;
using System.Globalization;
using System.Runtime.Serialization;
namespace Example_310
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public decimal Salary { get; set; }
        [DataMember]
        public int EmployeeNumber { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
        private const string dateFormat = "d.M.yyyy";
        //The class must have a parameterless constructor to make
        //sure that its objects can be serlialized az JSON.
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
            return EmployeeNumber + " " + EmployeeName + " " + Birthday.ToString(dateFormat, CultureInfo.InvariantCulture) + " " + Salary;
        }
    }
}