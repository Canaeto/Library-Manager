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
    public partial class Issue : UserControl
    {
        private static Issue _Issue;
        private string connectionString;
        private SqlConnection connection;

        
        private string sqlQuery;
       
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataSet ds;
        private DataSet tempDataSet;
        private DataTable userTable;
        // private MySQLInfoEnumerator sqlInfo;
        private SqlDataReader reader;
        private delegate string[] InternalDelegate();
        private InternalDelegate intlDelg;
        private delegate void AsyncDelegate(IAsyncResult result);
        // private delegate void TimerDelegate(object sender, ElapsedEventArgs e);
        //private System.Timers.Timer ticker;
        // private CallFor called;
       // private int currentIndex;
       // private bool isLastPage;
        private int totalRecords;
      //  private int currentPageStartRecord;
      //  private int currentPageEndRecord;
        public static Issue isu
        {
            get
            {
                if (_Issue == null)
                    _Issue = new Issue();
                return _Issue;

            }

        }

        public Issue()
        {
            InitializeComponent();
            Report r = new Report();
           
        }
        
        private void Issue_Load(object sender, EventArgs e)
        {
            populateBookCombo();
            populateBorrowerCombo();
            loadData();


        }
        private void populateBookCombo()
        {
            DbConnection db_con = new DbConnection();
            StringBuilder connStr = new StringBuilder();
            connStr.Append("server=");
            connStr.Append(db_con.m_Server);

            connStr.Append(";user=");
            connStr.Append(db_con.m_User);

            connStr.Append(";database=");
            connStr.Append(db_con.m_Database);


            connStr.Append(";password=");
            connStr.Append(db_con.m_Password);

            // connStr.Append(";Enlist=false; Asynchronous Processing=true");
            connectionString = connStr.ToString();
            //server=localhost;user=root;database=library;password=onyeje_25377
            //  MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
            //using (MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Books", connection))
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Books", connection))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                cbBooks.DataSource = dt;
                cbBooks.DisplayMember = "Book_title";
                cbBooks.ValueMember = "ISBN";
            }
        }
        private void populateBorrowerCombo()
        {
            DbConnection db_con = new DbConnection();
            StringBuilder connStr = new StringBuilder();
            connStr.Append("server=");
            connStr.Append(db_con.m_Server);

            connStr.Append(";user=");
            connStr.Append(db_con.m_User);

            connStr.Append(";database=");
            connStr.Append(db_con.m_Database);


            connStr.Append(";password=");
            connStr.Append(db_con.m_Password);

            // connStr.Append(";Enlist=false; Asynchronous Processing=true");
            connectionString = connStr.ToString();
            //server=localhost;user=root;database=library;password=onyeje_25377
            //  MessageBox.Show(connectionString);
            connection = new SqlConnection(connectionString);
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT borrower_CardNo,concat(borrower_CardNo,'-',borrower_surname,' ',borrower_firstname,' ',borrower_othername) as name FROM tbl_borrower", connection))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                this.cbBorrowers.DataSource = dt;
                this.cbBorrowers.DisplayMember = "name";
                this.cbBorrowers.ValueMember = "borrower_CardNo";
            }
        }

       
        DataClasses1DataContext da = new DataClasses1DataContext();
        

        //private void txt4_ValueChanged(object sender, EventArgs e)
        //{
        //   txt5.Text = (dtIssueDateTimePicker.Value - dtReturnDateTimePicker.Value).ToString();
        //}

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIsbn.Text = "";
            //lblIsbn.Text = this.cbBooks.SelectedValue.ToString();
            //  lblIsbn.Text = this.cbBooks.GetItemText(this.cbBooks.SelectedItem);
            lblIsbn.Text = this.cbBooks.GetItemText(this.cbBooks.SelectedValue);
           
            if (lblIsbn.Text == "Please select")
            {
                lblIsbn.Text = "";
            }
            else
            {
            }
        }

        private void cbBorrowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCardNum.Text = "";
            //lblCardNum.Text = this.cbBorrowers.SelectedValue.ToString();
            //  lblCardNum.Text = this.cbBorrowers.GetItemText(this.cbBooks.SelectedItem);
            lblCardNum.Text = this.cbBorrowers.GetItemText(this.cbBorrowers.SelectedValue);

            if (lblCardNum.Text == "Please select")
            {
                lblCardNum.Text = "";
            }
            else
            {
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            // txt5.Text = (dtIssueDateTimePicker.Value - dtReturnDateTimePicker.Value).ToString();
            //  decimal dateDiff1 = decimal.Parse(txt5.Text);
            string chkAvail = CheckAvailability();
            if (chkAvail == "No")
            {
                MessageBox.Show("Book not available");
            }
            else {
                IssueBook();
                loadData();
            }
           
            
        }
        public void IssueBook()
        {
            try
            {
                string connectionString;
                SqlConnection connect;
          

                DbConnection db_con = new DbConnection();
                StringBuilder connStr = new StringBuilder();
                connStr.Append("server=");
                // connStr.Append("localhost");
                connStr.Append(db_con.m_Server);

                connStr.Append(";user=");
                //connStr.Append(txtUserName.Text.Trim());
                connStr.Append(db_con.m_User);

                connStr.Append(";database=");
                // connStr.Append(cmbAllDataBases.Text);
                // connStr.Append("library");
                connStr.Append(db_con.m_Database);


                connStr.Append(";password=");
                //connStr.Append(txtPassword.Text.Trim());
                connStr.Append(db_con.m_Password);

                connectionString = connStr.ToString();
                //  MessageBox.Show(connectionString);
                connect = new SqlConnection(connectionString);

                int issuedid = getIssue_Id();
                issuedid = issuedid + 1;

                string yrIssued = dtIssueDateTimePicker.Value.Year.ToString();
                string mtIssued = dtIssueDateTimePicker.Value.Month.ToString();
                string dtIssued = dtIssueDateTimePicker.Value.Day.ToString();

                string dateIssued = yrIssued + '-' + mtIssued + '-' + dtIssued;
                //   MessageBox.Show(dateIssued);

                string yrToReturn = dtReturnDateTimePicker.Value.Year.ToString();
                string mtToReturn = dtReturnDateTimePicker.Value.Month.ToString();
                string dtToReturn = dtReturnDateTimePicker.Value.Day.ToString();

                string dateToReturn = yrToReturn + '-' + mtToReturn + '-' + dtToReturn;
                // MessageBox.Show(dateToReturn);

               

                SqlCommand cmd = new SqlCommand("", connect);
                if (lblIsbn.Text != "" && lblCardNum.Text != ""  )
                  {
                    string BookIsbn = this.cbBooks.GetItemText(this.cbBooks.SelectedValue);
                    string BorrowerCard = this.cbBorrowers.GetItemText(this.cbBorrowers.SelectedValue);
                    

                    connect.Open();
                    cmd.CommandText = "INSERT INTO IssueAndReturnStatus (Issued_borrower_CardNo, Issued_book_ISBN, Issue_date, Returning_date, ReturnStatus, dateEntered) " +
                                      "VALUES (@BorrowerCard, @BookIsbn, @IssueDate, @ReturningDate, 'No', GETDATE())";
                    cmd.Parameters.AddWithValue("@BorrowerCard", BorrowerCard);
                    cmd.Parameters.AddWithValue("@BookIsbn", BookIsbn);
                    cmd.Parameters.AddWithValue("@IssueDate", dateIssued);
                    cmd.Parameters.AddWithValue("@ReturningDate", dateToReturn);
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                  //  this.Hide();
                   // this.Show();
                    MessageBox.Show("Book has been Issued successfuly ");
                    UpdateBookStaus();
                    lblIsbn.Text = "";
                    lblCardNum.Text = "";
                    
                    // Report rp = new Report();
                    //rp.loadData(); 
                }
                else
                {
                    MessageBox.Show("empty fields are not allowed ! please make sure every data has been added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void UpdateBookStaus()
        {
            try
            {
                string connectionString;
                SqlConnection connect;


                DbConnection db_con = new DbConnection();
                StringBuilder connStr = new StringBuilder();
                connStr.Append("server=");
                // connStr.Append("localhost");
                connStr.Append(db_con.m_Server);

                connStr.Append(";user=");
                //connStr.Append(txtUserName.Text.Trim());
                connStr.Append(db_con.m_User);

                connStr.Append(";database=");
                // connStr.Append(cmbAllDataBases.Text);
                // connStr.Append("library");
                connStr.Append(db_con.m_Database);


                connStr.Append(";password=");
                //connStr.Append(txtPassword.Text.Trim());
                connStr.Append(db_con.m_Password);

                connectionString = connStr.ToString();
                //  MessageBox.Show(connectionString);
                connect = new SqlConnection(connectionString);

              
                SqlCommand cmd = new SqlCommand("", connect);
               
                
                    connect.Open();
                    cmd.CommandText = "update Books set  Status ='No' where ISBN='" + lblIsbn.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    this.Hide();
                    this.Show();
                    MessageBox.Show("Book status updated ");
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private int getIssue_Id()
        {
            int issuedId = 0;
            try
            {
               
                    string connectionString;
                    SqlConnection connect;
                    DbConnection db_con = new DbConnection();
                    StringBuilder connStr = new StringBuilder();
                    connStr.Append("server=");
                    // connStr.Append("localhost");
                    connStr.Append(db_con.m_Server);

                    connStr.Append(";user=");
                    //connStr.Append(txtUserName.Text.Trim());
                    connStr.Append(db_con.m_User);

                    connStr.Append(";database=");
                    // connStr.Append(cmbAllDataBases.Text);
                    // connStr.Append("library");
                    connStr.Append(db_con.m_Database);


                    connStr.Append(";password=");
                    //connStr.Append(txtPassword.Text.Trim());
                    connStr.Append(db_con.m_Password);

                    connectionString = connStr.ToString();
                    //  MessageBox.Show(connectionString);
                    connect = new SqlConnection(connectionString);

                    SqlCommand cmd = new SqlCommand("", connect);
                    SqlDataReader reader;
                  
                    connect.Open();
                    cmd.CommandText = "select max(Issue_Id) from IssueAndReturnStatus";
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                        issuedId = int.Parse(reader[0].ToString());
                            
                           
                        }

                    }
                  
                    connect.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
            return issuedId;
        }
        private string CheckAvailability()
        {
            string status = "";
            try
            {

                string connectionString;
                SqlConnection connect;
                DbConnection db_con = new DbConnection();
                StringBuilder connStr = new StringBuilder();
                connStr.Append("server=");
                // connStr.Append("localhost");
                connStr.Append(db_con.m_Server);

                connStr.Append(";user=");
                //connStr.Append(txtUserName.Text.Trim());
                connStr.Append(db_con.m_User);

                connStr.Append(";database=");
                // connStr.Append(cmbAllDataBases.Text);
                // connStr.Append("library");
                connStr.Append(db_con.m_Database);


                connStr.Append(";password=");
                //connStr.Append(txtPassword.Text.Trim());
                connStr.Append(db_con.m_Password);

                connectionString = connStr.ToString();
                //  MessageBox.Show(connectionString);
                connect = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("", connect);
                SqlDataReader reader;

                connect.Open();
                cmd.CommandText = "select ReturnStatus from IssueAndReturnStatus where Issued_book_ISBN='"+ lblIsbn.Text +"' ";
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        status = reader[0].ToString();


                    }

                }

                connect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
            return status;
        }
        public void loadData()
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            // lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
            // btnLoad.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (userTable != null)
                {
                    userTable.Clear();
                }
                userDataGridView.DataSource = null;
                userDataGridView.Rows.Clear();
                userDataGridView.Refresh();
                sqlQuery = "SELECT * FROM IssueAndReturnStatus";
                SetDataObjects();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSet);
                totalRecords = tempDataSet.Tables[0].Rows.Count;

                tempDataSet.Clear();
                tempDataSet.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "IssueAndReturnStatus");
                userTable = ds.Tables["IssueAndReturnStatus"];

                foreach (DataColumn dc in userTable.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = dc.ColumnName;
                    column.HeaderText = dc.ColumnName;
                    column.Name = dc.ColumnName;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.ValueType = dc.DataType;
                    userDataGridView.Columns.Add(column);
                }
                // lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;
              
                //CreateTempTable(0, int.Parse(100));
                CreateTempTable(0, 100);


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


        private void SetDataObjects()
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
            tempDataSet = new DataSet("TempDataSet");
        }
        private void CreateTempTable(int startRecord, int noOfRecords)
        {
           

            try
            {
                userTable.Rows.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim());
                adapter.Fill(ds, startRecord, noOfRecords, "IssueAndReturnStatus");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTable = ds.Tables["IssueAndReturnStatus"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            userDataGridView.DataSource = userTable.DefaultView;
            userDataGridView.AllowUserToResizeColumns = true;
        }

        private void dtReturnDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           // txt5.Text = (dtReturnDateTimePicker.Value - dtIssueDateTimePicker.Value).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        public void Search()
        {
           
        
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (userTable != null)
                {
                    userTable.Clear();
                }
                userDataGridView.DataSource = null;
                userDataGridView.Rows.Clear();
                userDataGridView.Refresh();
                sqlQuery = "SELECT * FROM IssueAndReturnStatus where Issued_book_ISBN='" + txtSearchISBN.Text +"'";
                SetDataObjects();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSet);
                totalRecords = tempDataSet.Tables[0].Rows.Count;

                tempDataSet.Clear();
                tempDataSet.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "IssueAndReturnStatus");
                userTable = ds.Tables["IssueAndReturnStatus"];

                foreach (DataColumn dc in userTable.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.DataPropertyName = dc.ColumnName;
                    column.HeaderText = dc.ColumnName;
                    column.Name = dc.ColumnName;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                    column.ValueType = dc.DataType;
                    userDataGridView.Columns.Add(column);
                }
                // lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;

                //CreateTempTable(0, int.Parse(100));
                CreateTempTable(0, 100);


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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
