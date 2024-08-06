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
    public partial class Return : UserControl
    {
        private static Return _Return;
        //private static Issue _Issue;
        private string connectionString;
        private SqlConnection connection;


        private string sqlQuery;

        private SqlCommand command;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder builder;
        private DataSet ds;
        private DataSet tempDataSet;
        private DataTable userTable;
        private SqlDataReader reader;
        private delegate string[] InternalDelegate();
        private InternalDelegate intlDelg;
        private delegate void AsyncDelegate(IAsyncResult result);
        private int totalRecords;
        public static Return Ret
        {
            get
            {
                if (_Return == null)
                    _Return = new Return();
                return _Return;

            }

        }
        public Return()
        {
            InitializeComponent();
         
        }
        DataClasses1DataContext dta = new DataClasses1DataContext();
        
       

        private void Return_Load(object sender, EventArgs e)
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
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            loadData();
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
                sqlQuery = "SELECT * FROM IssueAndReturnStatus where Issued_borrower_CardNo='" + txtSearchCardNumber.Text + "'";
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

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            int df = CheckDateDiff();
           // MessageBox.Show("Date different:" + df);
            int IssuedidFind = getIssue_IdForFine();
            // MessageBox.Show("IssuedidFind:" + IssuedidFind);
            if (df > 0)
            {
                InsertFine(IssuedidFind, df);
            }
            string ismatch = CheckRecordMatch();
            if (ismatch != "") { 
            UpdateIssueAndReturnStatus();
            loadData();
            }
            else MessageBox.Show("Record not matched");
        }
        public void UpdateIssueAndReturnStatus()
        {
            string yrToReturn = dtReturnDateTimePicker.Value.Year.ToString();
            string mtToReturn = dtReturnDateTimePicker.Value.Month.ToString();
            string dtToReturn = dtReturnDateTimePicker.Value.Day.ToString();

            string dateToReturn = yrToReturn + '-' + mtToReturn + '-' + dtToReturn;
            try
            {
                if (lblIsbn.Text != "" && lblCardNum.Text != "")
                {
                 string BookIsbn = this.cbBooks.GetItemText(this.cbBooks.SelectedValue);
                 string BorrowerCard = this.cbBorrowers.GetItemText(this.cbBorrowers.SelectedValue);
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
                cmd.CommandText = "update IssueAndReturnStatus set  ReturnStatus ='Yes', Returning_date='" + dateToReturn + "'  where Issued_book_ISBN='" + lblIsbn.Text + "' and Issued_borrower_CardNo='" + lblCardNum.Text + "'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
               // this.Hide();
                //this.Show();
                MessageBox.Show("Book Return Successfully ");
                    UpdateBookStaus();

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
                cmd.CommandText = "update Books set  Status ='Yes' where ISBN='" + lblIsbn.Text + "'";
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
        private string CheckRecordMatch()
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
                cmd.CommandText = "select Issued_borrower_CardNo from IssueAndReturnStatus where Issued_book_ISBN='" + lblIsbn.Text + "' and Issued_borrower_CardNo='" + lblCardNum.Text + "' ";
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
        private int CheckDateDiff()
        {
            int df = 0;
            DateTime returnDate = dtReturnDateTimePicker.Value;

            try
            {
                string connectionString;
                SqlConnection connect;
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

                connectionString = connStr.ToString();
                connect = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand("", connect);
                SqlDataReader reader;

                connect.Open();
                cmd.CommandText = @"
            SELECT DATEDIFF(day, Returning_date, @ReturnDate) AS df 
            FROM IssueAndReturnStatus 
            WHERE Issued_book_ISBN = @BookISBN 
              AND Issued_borrower_CardNo = @CardNumber";

                // Adding parameters to the SQL command
                cmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmd.Parameters.AddWithValue("@BookISBN", lblIsbn.Text);
                cmd.Parameters.AddWithValue("@CardNumber", lblCardNum.Text);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        df = int.Parse(reader["df"].ToString());
                    }
                }

                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            return df;
        }
        private int getIssue_IdForFine()
        {
            int issueId = 0;
           

           
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
                cmd.CommandText = "select  Issue_Id from IssueAndReturnStatus where Issued_book_ISBN='" + lblIsbn.Text + "' and Issued_borrower_CardNo='" + lblCardNum.Text + "' and ReturnStatus='No' ";
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                         issueId  = int.Parse(reader[0].ToString());


                    }

                }

                connect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
            return issueId;
        }
        public void InsertFine(int issued_id, int NumberOfdateDefaulted)
        {
            string yrToReturn = dtReturnDateTimePicker.Value.Year.ToString();
            string mtToReturn = dtReturnDateTimePicker.Value.Month.ToString();
            string dtToReturn = dtReturnDateTimePicker.Value.Day.ToString();

            string dateToReturn = yrToReturn + '-' + mtToReturn + '-' + dtToReturn;
            try
            {
                if (lblIsbn.Text != "" && lblCardNum.Text != "")
                {
                    string BookIsbn = this.cbBooks.GetItemText(this.cbBooks.SelectedValue);
                    string BorrowerCard = this.cbBorrowers.GetItemText(this.cbBorrowers.SelectedValue);
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
                    cmd.CommandText = "insert into  fines(Issue_Id,Issued_book_ISBN,Issued_borrower_CardNo,NumberOfdateDefaulted,fine_date) values(" + issued_id + " ,'" + lblIsbn.Text + "','" + lblCardNum.Text + "', "+ NumberOfdateDefaulted +",'"+ dateToReturn + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    // this.Hide();
                    //this.Show();
                    MessageBox.Show("Fine added");
                  

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

    }
}
