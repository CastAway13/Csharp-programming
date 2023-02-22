using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Example_62
{
    public partial class MainForm : Form
    {
        OleDbConnection oleDBConnection;
        OleDbCommand oleDbCommand;
        InsertDataForm insertDataForm;
        string connectionString;
        string errorFeedback;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            errorFeedback = "Problem with database connection!";

        }
        private void PreapreConnection(string connString, string errorFeedback)
        {

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
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show(errorFeedback + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CloseDBConnection()
        {
            if (oleDBConnection != null)
                oleDBConnection.Close();
        }
        private void FetchDataButton_Click(object sender, EventArgs e)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSurceTextBox.Text;
            PreapreConnection(connectionString, errorFeedback);
            //Here we create a DataTable object
            DataTable dataTable = new DataTable();
            //Here we fill the dataTable with the results of the SQL query
            dataTable.Load(oleDbCommand.ExecuteReader());
            //Here we set the dataTable as the data source of the dataGridview
            dataGridView.DataSource = dataTable;
            //The following code snippet shows anoter way of populating the DatGridView
            ////Here we read the query results to an OleDbDataAdapter
            //OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            ////Here we use the OleDbDataAdapter object to fill the DataTable object
            //oleDbDataAdapter.Fill(dataTable);
            ////Here we set the dataTable with it's default view as the DataSource of the DataGridview
            //dataGridView.DataSource = dataTable.DefaultView;
            //Here we close the database connection.
            CloseDBConnection();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView.DataSource;
            if (dataTable != null)
            {
                dataTable.Clear();
                dataGridView.DataSource = null;
                dataGridView.Refresh();
            }

        }
        private void FetchMetaData_Click(object sender, EventArgs e)
        {
            string errorFeedback = "Problem with database connection!";
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSurceTextBox.Text;
            PreapreConnection(connectionString, errorFeedback);
            //Here we create a DataTable object
            DataTable dataTable = new DataTable();
            //Here we fill the dataTable with the meta data from the underlying table of the SQL query
            dataTable.Load(oleDbCommand.ExecuteReader(CommandBehavior.SchemaOnly));

            //Here we set the dataTable as the source of the data grid view     
            dataGridView.DataSource = dataTable;
            //Here we close the database connection.
            CloseDBConnection();

        }
        private void InsertDataButton_Click(object sender, EventArgs e)
        {
            //  string errorFeedback = "Problem with database connection!";
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSurceTextBox.Text;
            if (insertDataForm == null || insertDataForm.IsDisposed)
            {
                insertDataForm = new InsertDataForm(this, connectionString);

            }
            insertDataForm.Show();
        }
    }
}