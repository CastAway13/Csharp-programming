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
    public partial class Summary : Form
    {
        string filePathCustomer = @"D:\Study\Windows\Ass9\Customer.txt";
        string filePathFlight = @"D:\Study\Windows\Ass9\Fligth.txt";
        public Summary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            JSONSerializer jsonSerializerCustomer = new JSONSerializer(filePathCustomer);
            List<Customer> cusObject = jsonSerializerCustomer.ReadCustomerFromJSONFile();
            string result = "ID\t\t\tName\t\t\tFlight ID";
            foreach (Customer customer in cusObject)
            {
                result += customer.ToString();
            }
            richTextBox2.Text += result;

            richTextBox1.Clear();
            JSONSerializer jsonSerializerFlight = new JSONSerializer(filePathFlight);
            List<Flight> fliObject = jsonSerializerFlight.ReadFlightFromJSONFile();
            result = "ID\t\tAirline\t\tOrigin\t\tDestination\t\tDate";
            foreach (Flight flight in fliObject)
            {
                result += flight.ToString();
            }
            richTextBox1.Text += result;
        }
    }
}
