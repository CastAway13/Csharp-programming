using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class CustomerForm : Form
    {
        string filePath = @"D:\Study\Windows\Ass9\Customer.txt";
        List<Customer> customers = new List<Customer>();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customers.Add(new Customer(customerIdTextBox.Text, customerNameTextBox.Text, CustomerFlightIdTextBox.Text));
            JSONSerializer jsonSerializer = new JSONSerializer(filePath);
            jsonSerializer.WriteToJSONFileCustomer(customers);
        }
    }
}
