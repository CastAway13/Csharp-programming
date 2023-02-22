using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Example_61
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void FetchDataButton_Click(object sender, EventArgs e)
        {
            string errorFeedback = "Problem with database connection!";
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSurceTextBox.Text;
            OleDbConnection oleDBConnection = null;
            OleDbCommand oleDbCommand = null;
            OleDbDataReader dataReader = null;
            try
            {
                //Here we create an instance of OleDbConnection
                oleDBConnection = new OleDbConnection(connString);

                //Here we cretae an instance of OleDbCommand
                oleDbCommand = oleDBConnection.CreateCommand();

                //Here we set the text for OleDbCommand object
                oleDbCommand.CommandText = sqlQueryTextBox.Text;

                //Here we open the connection to the database
                oleDBConnection.Open();
                //Here we create an objcet of OleDbDataReader, which will hold the result
                //of executing the select command on the table.
                dataReader = oleDbCommand.ExecuteReader();
                //Here we find out the number of columns returned by the query
                int fieldCount = dataReader.FieldCount;
                //Here we cleare the text box
                outputRichTextBox.Clear();
                outputRichTextBox.Text += "Column names:\t";
                //Here we disply the name of each column in the query result
                for (int i = 0; i < fieldCount; i++)
                {
                    //Here dataReader.GetName(i) returns the name of the column at index i
                    outputRichTextBox.Text += dataReader.GetName(i) + "\t";
                }
                outputRichTextBox.Text += Environment.NewLine;
                outputRichTextBox.Text += "Data Types:\t";
                //Here we disply the data type of each column in the query result
                for (int i = 0; i < fieldCount; i++)
                {
                    //Here dataReader.GetDataTypeName(i) returns the name of the data type of the column at index i
                    outputRichTextBox.Text += dataReader.GetDataTypeName(i) + "\t";
                }
                outputRichTextBox.Text += Environment.NewLine;
                //Here we define a counter for counting rows
                int rowCounter = 1;
                //In the following we go through each row of the query result and display the value of each column in the row  
                while (dataReader.Read())
                {
                    //Here we display the row number
                    outputRichTextBox.Text += "Row " + rowCounter + ".\t\t";
                    for (int i = 0; i < fieldCount; i++)
                    {
                        outputRichTextBox.Text += dataReader[dataReader.GetName(i)] + "\t\t";
                    }

                    outputRichTextBox.Text += Environment.NewLine;
                    rowCounter++;
                }
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(errorFeedback + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oleDBConnection != null)
                    oleDBConnection.Close();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();
        }
        private void FetchMetaData_Click(object sender, EventArgs e)
        {
            string errorFeedback = "Problem with database connection!";
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSurceTextBox.Text;
            OleDbConnection oleDBConnection = null;
            OleDbCommand oleDbCommand = null;
            OleDbDataReader dataReader = null;
            try
            {
                //Here we create an instance of OleDbConnection
                oleDBConnection = new OleDbConnection(connString);
                //Here we cretae an instance of OleDbCommand
                oleDbCommand = oleDBConnection.CreateCommand();
                //Here we set the text for OleDbCommand object
                oleDbCommand.CommandText = sqlQueryTextBox.Text;
                //Here we open the connection to the database
                oleDBConnection.Open();
                //Here we create an objcet of OleDbDataReader, which will hold the result
                //of executing the select command on the table.
                //Here we set the command behavior to get meta data about the underlying table.
                dataReader = oleDbCommand.ExecuteReader(CommandBehavior.SchemaOnly);
                //Here we clear the text box
                outputRichTextBox.Clear();
                //We get the information about the table using the GetSchemaTable() method of OleDbDataReader object.
                //Here we get the SchemaTable, which includes meta data about the table
                DataTable schemaTable = dataReader.GetSchemaTable();
                foreach (DataRow dataRow in schemaTable.Rows)
                {
                    foreach (DataColumn dataColumn in schemaTable.Columns)
                    {
                        outputRichTextBox.Text += dataColumn + " = " + dataRow[dataColumn] + '\n';
                    }
                }
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(errorFeedback + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (oleDBConnection != null)
                    oleDBConnection.Close();
            }
        }
    }
}
