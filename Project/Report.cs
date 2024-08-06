using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using System.Data.SqlClient;

namespace Project
{
    public partial class Report : UserControl
    {
        
        private static Report _Report;

        private string connectionString;
        private SqlConnection connection;


        private string sqlQuery;

        private SqlCommand command;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataSet ds;
        private DataSet tempDataSetBook;
        private DataTable userTableBook;
        private DataSet tempDataSetBorrower;
        private DataTable userTableBorrower;
        private DataSet tempDataSetBorrowedBook;
        private DataTable userTableBorrowedBook;
        private SqlDataReader reader;
        private delegate string[] InternalDelegate();
        private InternalDelegate intlDelg;
        private delegate void AsyncDelegate(IAsyncResult result);
        private int totalRecords;

        public static Report rep
        {
            get
            {
                if (_Report == null)
                    _Report = new Report();
                return _Report;

            }

        }
        public Report()
        {
            InitializeComponent();
          
        }

        public void showTables()
        {
          
        }
        DataClasses1DataContext dba = new DataClasses1DataContext();
       

        private void Report_Load(object sender, EventArgs e)
        {
            loadBookDetail();
           loadBorrowedBookDetail();
            loadBorrowersDetail();


        }
       

      


        public void loadBookDetail()
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            // lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
            // btnLoad.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (userTableBook != null)
                {
                    userTableBook.Clear();
                }
                dtgBookDetail.DataSource = null;
                dtgBookDetail.Rows.Clear();
                dtgBookDetail.Refresh();
                sqlQuery = "SELECT * FROM Books";
                SetDataObjectsBooks();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSetBook);
                totalRecords = tempDataSetBook.Tables[0].Rows.Count;

                tempDataSetBook.Clear();
                tempDataSetBook.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "Books");
                userTableBook = ds.Tables["Books"];

                foreach (DataColumn dc in userTableBook.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = dc.ColumnName;
                    column.HeaderText = dc.ColumnName;
                    column.Name = dc.ColumnName;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.ValueType = dc.DataType;
                    dtgBookDetail.Columns.Add(column);
                }
                // lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;

                //CreateTempTable(0, int.Parse(100));
                CreateTempTableBooks(0, 100);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                // btnLoad.Enabled = true;
                this.Cursor = Cursors.Default;
                // prgProgress.Value = 0;
                // prgProgress.Update();
                // prgProgress.Refresh();
                // ticker.Stop();
            }

        }
        public void loadBorrowedBookDetail()
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            // lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
            // btnLoad.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (userTableBorrowedBook != null)
                {
                    userTableBorrowedBook.Clear();
                }
                dtgBorrowedBookReport.DataSource = null;
                dtgBorrowedBookReport.Rows.Clear();
                dtgBorrowedBookReport.Refresh();
                sqlQuery = "SELECT * FROM IssueAndReturnStatus";
                SetDataObjectsBorroedBook();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSetBorrowedBook);
                totalRecords = tempDataSetBorrowedBook.Tables[0].Rows.Count;

                tempDataSetBorrowedBook.Clear();
                tempDataSetBorrowedBook.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "IssueAndReturnStatus");
                userTableBorrowedBook = ds.Tables["IssueAndReturnStatus"];

                foreach (DataColumn dc in userTableBorrowedBook.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = dc.ColumnName;
                    column.HeaderText = dc.ColumnName;
                    column.Name = dc.ColumnName;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.ValueType = dc.DataType;
                    dtgBorrowedBookReport.Columns.Add(column);
                }
                // lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;

                //CreateTempTable(0, int.Parse(100));
               CreateTempTableBorrowedBook(0, 100);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                // btnLoad.Enabled = true;
                this.Cursor = Cursors.Default;
                // prgProgress.Value = 0;
                // prgProgress.Update();
                // prgProgress.Refresh();
                // ticker.Stop();
            }

        }
        public void loadBorrowersDetail()
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            // lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
            // btnLoad.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (userTableBorrower != null)
                {
                    userTableBorrower.Clear();
                }
                dtgBorrowersDetail.DataSource = null;
                dtgBorrowersDetail.Rows.Clear();
                dtgBorrowersDetail.Refresh();
                sqlQuery = "SELECT * FROM IssueAndReturnStatus";
                SetDataObjectsBorrowers();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSetBorrower);
                totalRecords = tempDataSetBorrower.Tables[0].Rows.Count;

                tempDataSetBorrower.Clear();
                tempDataSetBorrower.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "IssueAndReturnStatus");
                userTableBorrower = ds.Tables["IssueAndReturnStatus"];

                foreach (DataColumn dc in userTableBorrower.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = dc.ColumnName;
                    column.HeaderText = dc.ColumnName;
                    column.Name = dc.ColumnName;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.ValueType = dc.DataType;
                    dtgBorrowersDetail.Columns.Add(column);
                }
                // lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;

                //CreateTempTable(0, int.Parse(100));
                CreateTempTableBorrowers(0, 100);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                // btnLoad.Enabled = true;
                this.Cursor = Cursors.Default;
                // prgProgress.Value = 0;
                // prgProgress.Update();
                // prgProgress.Refresh();
                // ticker.Stop();
            }

        }

        private void SetDataObjectsBooks()
        {
            DbConnection db_con = new DbConnection();
            StringBuilder connStr = new StringBuilder();
            connStr.Append("server=");
            // connStr.Append("localhost");
            connStr.Append(db_con.m_Server);

            connStr.Append(";user=");
            //connStr.Append(txtUserName.Text.Trim());
            //connStr.Append("root");
            connStr.Append(db_con.m_User);

            connStr.Append(";database=");
            // connStr.Append(cmbAllDataBases.Text);
            // connStr.Append("library");
            connStr.Append(db_con.m_Database);


            connStr.Append(";password=");
            //connStr.Append(txtPassword.Text.Trim());
            //connStr.Append("onyeje_25377");
            connStr.Append(db_con.m_Password);

            // connStr.Append(";Enlist=false; Asynchronous Processing=true");
            connectionString = connStr.ToString();
            //server=localhost;user=root;database=library;password=onyeje_25377
            //  MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
            // MySqlCommand cmd = new MySqlCommand("", connection);
            command = new SqlCommand(sqlQuery, connection);
            adapter = new SqlDataAdapter(command);
            builder = new SqlCommandBuilder(adapter);
            ds = new DataSet("MainDataSet");
            tempDataSetBook = new DataSet("TempDataSet");
        }
        private void SetDataObjectsBorrowers()
        {
            DbConnection db_con = new DbConnection();
            StringBuilder connStr = new StringBuilder();
            connStr.Append("server=");
            // connStr.Append("localhost");
            connStr.Append(db_con.m_Server);

            connStr.Append(";user=");
            //connStr.Append(txtUserName.Text.Trim());
            //connStr.Append("root");
            connStr.Append(db_con.m_User);

            connStr.Append(";database=");
            // connStr.Append(cmbAllDataBases.Text);
            // connStr.Append("library");
            connStr.Append(db_con.m_Database);


            connStr.Append(";password=");
            //connStr.Append(txtPassword.Text.Trim());
            //connStr.Append("onyeje_25377");
            connStr.Append(db_con.m_Password);

            // connStr.Append(";Enlist=false; Asynchronous Processing=true");
            connectionString = connStr.ToString();
            //server=localhost;user=root;database=library;password=onyeje_25377
            //  MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
            // MySqlCommand cmd = new MySqlCommand("", connection);
            command = new SqlCommand(sqlQuery, connection);
            adapter = new SqlDataAdapter(command);
            builder = new SqlCommandBuilder(adapter);
            ds = new DataSet("MainDataSet");
            tempDataSetBorrower = new DataSet("TempDataSet");
        }
        private void SetDataObjectsBorroedBook()
        {
            DbConnection db_con = new DbConnection();
            StringBuilder connStr = new StringBuilder();
            connStr.Append("server=");
            // connStr.Append("localhost");
            connStr.Append(db_con.m_Server);

            connStr.Append(";user=");
            //connStr.Append(txtUserName.Text.Trim());
            //connStr.Append("root");
            connStr.Append(db_con.m_User);

            connStr.Append(";database=");
            // connStr.Append(cmbAllDataBases.Text);
            // connStr.Append("library");
            connStr.Append(db_con.m_Database);


            connStr.Append(";password=");
            //connStr.Append(txtPassword.Text.Trim());
            //connStr.Append("onyeje_25377");
            connStr.Append(db_con.m_Password);

            // connStr.Append(";Enlist=false; Asynchronous Processing=true");
            connectionString = connStr.ToString();
            //server=localhost;user=root;database=library;password=onyeje_25377
            //  MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
            // MySqlCommand cmd = new MySqlCommand("", connection);
            command = new SqlCommand(sqlQuery, connection);
            adapter = new SqlDataAdapter(command);
            builder = new SqlCommandBuilder(adapter);
            ds = new DataSet("MainDataSet");
            tempDataSetBorrowedBook = new DataSet("TempDataSet");
        }
        private void CreateTempTableBorrowedBook(int startRecord, int noOfRecords)
        {


            try
            {
                userTableBorrowedBook.Rows.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim());
                adapter.Fill(ds, startRecord, noOfRecords, "IssueAndReturnStatus");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTableBorrowedBook = ds.Tables["IssueAndReturnStatus"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            dtgBorrowedBookReport.DataSource = userTableBorrowedBook.DefaultView;
            dtgBorrowedBookReport.AllowUserToResizeColumns = true;
        }

        private void CreateTempTableBooks(int startRecord, int noOfRecords)
        {


            try
            {
                userTableBook.Rows.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim());
                adapter.Fill(ds, startRecord, noOfRecords, "Books");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTableBook = ds.Tables["Books"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            dtgBookDetail.DataSource = userTableBook.DefaultView;
            dtgBookDetail.AllowUserToResizeColumns = true;
        }
        private void CreateTempTableBorrowers(int startRecord, int noOfRecords)
        {


            try
            {
                userTableBorrower.Rows.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim());
                adapter.Fill(ds, startRecord, noOfRecords, "tbl_borrower");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTableBorrower = ds.Tables["tbl_borrower"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            dtgBorrowersDetail.DataSource = userTableBorrower.DefaultView;
            dtgBorrowersDetail.AllowUserToResizeColumns = true;
        }

        private void tnbRefresh_Click(object sender, EventArgs e)
        {
            loadBookDetail();
            loadBorrowedBookDetail();
        }
    }
}
