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
    public partial class SearchFlight : Form
    {
        string filePathCustomer = @"D:\Study\Windows\Ass9\Customer.txt";
        string filePathFlight = @"D:\Study\Windows\Ass9\Fligth.txt";
        Size originalSize;
        int incrementPercent = 5;
        public SearchFlight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            JSONSerializer jsonSerializerCustomer = new JSONSerializer(filePathCustomer);
            List<Customer> cusObject = jsonSerializerCustomer.ReadCustomerFromJSONFile();
            string searchId = searchFlightIdtextBox1.Text;

            JSONSerializer jsonSerializerFlight = new JSONSerializer(filePathFlight);
            List<Flight> fliObject = jsonSerializerFlight.ReadFlightFromJSONFile();

            string result = "ID\t\tAirline\t\tOrigin\t\tDestination\t\tDate";
            foreach (Flight flight in fliObject)
            {
                if (flight.FindFlight(searchId))
                {
                    result += flight.ToString();
                }
            }
            richTextBox1.Text += result;

            result = "\n\nID\t\t\tName\t\t\tFlight ID";
            foreach (Customer customer in cusObject)
            {
                if (customer.FindCustomerWithFlightId(searchId))
                {
                    result += customer.ToString();
                    
                }
            }
            richTextBox1.Text += result;
        }

        private void SearchFlight_Load(object sender, EventArgs e)
        {
            originalSize = richTextBox1.Size;
        }

        private void rEdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Blue;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void biggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size currentSize = richTextBox1.Size;
            int newWidth = (int)(currentSize.Width * (1 + incrementPercent / 100.0));
            int newHeight = (int)(currentSize.Height * (1 + incrementPercent / 100.0));
            if (newWidth >= 2 * originalSize.Width || (newHeight >= 2 * originalSize.Height))
                return;
            richTextBox1.Size = new Size(newWidth, newHeight);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Size = originalSize;
        }

        private void smallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size currentSize = richTextBox1.Size;
            int newWidth = (int)(currentSize.Width * (1 - incrementPercent / 100.0));
            int newHeight = (int)(currentSize.Height * (1 - incrementPercent / 100.0));
            if (newWidth <= 0.5 * originalSize.Width || (newHeight <= 0.5 * originalSize.Height))
                return;
            richTextBox1.Size = new Size(newWidth, newHeight);
        }
    }
}
