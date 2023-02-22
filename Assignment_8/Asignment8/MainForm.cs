using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment8
{
    public partial class MainForm : Form
    {
        Summary summaryForm;
        string data;
        public MainForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {    
            data += "\n\n\nFlight ID: " + FlightIdTextBox.Text + "\nOrigin Box: " + OriginTextBox.Text + "\nDestination Box: " + DestinationTextBox.Text + 
                "\nDate: " + DateBox.Text + "\nTime: " + TimeTextBox.Text + "\n";
            if (summaryForm == null || summaryForm.IsDisposed)
            {
                summaryForm = new Summary();
                
            }
            summaryForm.AddData(data);
            summaryForm.Show();
        }
        
    }
}
