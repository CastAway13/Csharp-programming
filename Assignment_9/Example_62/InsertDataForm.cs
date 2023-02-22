using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Example_62
{
    public partial class InsertDataForm : Form
    {
        MainForm mainForm;
        string connectionString;
        private OleDbConnection oleDbConnection;
        private OleDbCommand insertCommand;
        private OleDbDataAdapter oleDbDataAdapter;
        private DataRow newDataRow;
        public InsertDataForm(MainForm mainForm, string connectionString)
        {
            this.mainForm = mainForm;
            this.connectionString = connectionString;
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();


        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            //Here we make sure that text boxes are not empty
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) ||
           string.IsNullOrEmpty(titleTextBox.Text))
            {
                MessageBox.Show("Please give valid values!");
                return;
            }
            oleDbConnection = new OleDbConnection(connectionString);

            //Here we create a command objecd for inserting new rows
            insertCommand = oleDbConnection.CreateCommand();
            insertCommand.CommandText = "insert into Employees (EmployeeID, LastName, FirstName, Title) values( @employeeID, @lastName, @firstName, @title )";
            insertCommand.Parameters.AddWithValue("@employeeID", int.Parse(employeeIDTextBox.Text));
            insertCommand.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
            insertCommand.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
            insertCommand.Parameters.AddWithValue("@title", titleTextBox.Text);

            //Here we prepare a SQL query with which the OleDbDataAdapter will be intialised
            string selectQueryString = "SELECT * FROM Employees";
            //Here we initialise oleDbDataAdapter, which represents the set of data commands and
            //database connection used to fill the DataSet and update the data source.
            oleDbDataAdapter = new OleDbDataAdapter(selectQueryString, connectionString);
            //Here we define SQL insert command for the oleDbDataAdapter
            oleDbDataAdapter.InsertCommand = insertCommand;
            //Here we define a DataSet for keeping different sets of tables and columns
            DataSet employeesDataSet = new DataSet();
            //Here we create Employees table in employeesDataSet
            oleDbDataAdapter.Fill(employeesDataSet, "Employees");
            //Here we prepare a new data row for Employees table and initialise it's columns
            newDataRow = employeesDataSet.Tables["Employees"].NewRow();
            newDataRow["EmployeeID"] = employeeIDTextBox.Text;
            newDataRow["LastName"] = lastNameTextBox.Text;
            newDataRow["FirstName"] = firstNameTextBox.Text;
            newDataRow["Title"] = titleTextBox.Text;
            //Here we add the new row to Employees table in the employeesDataSet
            employeesDataSet.Tables["Employees"].Rows.Add(newDataRow);
            //Here we open the database connection
            oleDbConnection.Open();
            //Here we call the oleDbDataAdapter Update() command to insert data to the underlying
            //data source of employeesDataSet and get the update result
            int numOfRows = oleDbDataAdapter.Update(employeesDataSet.Tables["Employees"]);
            MessageBox.Show(numOfRows + " row was added");
            oleDbConnection.Close();

        }
    }
}
