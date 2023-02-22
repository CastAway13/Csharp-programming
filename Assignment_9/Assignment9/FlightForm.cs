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
    public partial class FlightForm : Form
    {
        string filePath = @"D:\Study\Windows\Ass9\Fligth.txt";
        List<Flight> flights = new List<Flight>();
        CustomerForm customerForm;
        Summary summaryForm;
        SearchCustomer searchCustomerForm;
        SearchFlight searchFlightForm;
        
        public FlightForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            flights.Add(new Flight(flightIdBox.Text, airlineTextBox.Text, originTextBox.Text ,destinationTextBox.Text, dateTimePicker.Text));
            JSONSerializer jsonSerializer = new JSONSerializer(filePath);
            jsonSerializer.WriteToJSONFileFlight(flights);
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerForm == null || customerForm.IsDisposed)
            {
                customerForm = new CustomerForm();

            }
            customerForm.Show();
        }

        private void flightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchFlightForm == null || searchFlightForm.IsDisposed)
            {
                searchFlightForm = new SearchFlight();

            }
            searchFlightForm.Show();

        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (searchCustomerForm == null || searchCustomerForm.IsDisposed)
            {
                searchCustomerForm = new SearchCustomer();

            }
            searchCustomerForm.Show();
        }

        private void summaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (summaryForm == null || summaryForm.IsDisposed)
            {
                summaryForm = new Summary();

            }
            summaryForm.Show();

        }
    }
}
