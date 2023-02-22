using System;
using System.Windows.Forms;
namespace Example_42
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] comboBoxContent = new string[] { "OK", "OK Cancel","Abort, Retry, Ignore",
            "Yes, No, Cancel", "Yes, No", "Retry, Cancel"};
            optionsComboBox.Items.AddRange(comboBoxContent);
        }
        private void optionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem;
            DialogResult dialogResult = DialogResult.None;
            selectedItem = optionsComboBox.Text;
            //Here we initialize the text value of textBox
            feedbackTextBox.Text = optionsComboBox.Text;
            switch (selectedItem.Trim())
            {
                case "OK":
                    dialogResult = MessageBox.Show("The default style!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "OK Cancel":
                    dialogResult = MessageBox.Show("A choice of OK or Cancel!", "OK Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                        this.infoLabel.Text = "You pressed " + dialogResult.ToString();
                    break;
                case "Abort, Retry, Ignore":
                    dialogResult = MessageBox.Show("Three choices: Abort, Retry, Ignore!", "Abort, Retry, Ignore", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Ignore)
                        this.infoLabel.Text = "You pressed " + dialogResult.ToString();
                    break;
                case "Yes, No, Cancel":
                    dialogResult = MessageBox.Show("Three choices: Yes, No, cancel!", "Yes, No, cancel", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Hand);
                    if (dialogResult == DialogResult.Cancel)
                        this.infoLabel.Text = "You pressed " + dialogResult.ToString();
                    break;
                case "Yes, No":
                    dialogResult = MessageBox.Show("Yes or No!", "Yes, No", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                        this.infoLabel.Text = "You pressed " + dialogResult.ToString();
                    break;
                case "Retry, Cancel":
                    dialogResult = MessageBox.Show("Retry or Cancel!", "Retry, Cancel", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.Yes)
                        this.infoLabel.Text = "You pressed " + dialogResult.ToString();
                    break;
            }
            this.infoLabel.Text += " " + dialogResult.ToString() + " ";
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}