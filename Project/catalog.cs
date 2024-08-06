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
    public partial class catalog : UserControl
    {
        private static catalog _catalog;
       // private static Add_book _Books;
        private string connectionString;
        private string sqlQuery;
        private SqlConnection connection;
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
        private System.Timers.Timer ticker;
        // private CallFor called;
        private int currentIndex;
        private bool isLastPage;
        private int totalRecords;
        private int currentPageStartRecord;
        private int currentPageEndRecord;
        public static catalog cata
        {
            get
            {
                if (_catalog == null)
                    _catalog = new catalog();
                return _catalog;

            }

        }

        public catalog()
        {
            InitializeComponent();
            btnLoad.Enabled = true;
            
            prgProgress.Minimum = 0;
            prgProgress.Maximum = 200;
            ticker = new System.Timers.Timer();
            // intlDelg = new InternalDelegate(sqlInfo.EnumerateSQLServers);
            // ticker.Elapsed += new ElapsedEventHandler(ticker_Elapsed);
            //ticker.Interval = 250;
            cmbNoOfRecords.SelectedIndex = 0;
            drpCategory.SelectedIndex = 0;
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
           
            cmbNoOfRecords.Enabled = false;

        }
        DataClasses1DataContext dta = new DataClasses1DataContext();
       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          //  (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Book_Name LIKE ={0}%", textBox5.Text);
        }

        

        private void catalog_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            // lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
            // btnLoad.Enabled = false;
            string book_category = drpCategory.SelectedItem.ToString();
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
                sqlQuery = "SELECT * FROM Books where Category ='" + book_category + "'";
                SetDataObjects();
                connection.Open();
                //ticker.Start();
                adapter.Fill(tempDataSet);
                totalRecords = tempDataSet.Tables[0].Rows.Count;

                tempDataSet.Clear();
                tempDataSet.Dispose();
                //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
                //  userTable = ds.Tables[cmbTables.Text.Trim()];
                // adapter.Fill(ds, 0, 5, "Books");
                adapter.Fill(ds, "Books");
                userTable = ds.Tables["Books"];

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
                lblTotRecords.Text = "Total records: " + totalRecords;
                //string numberOfRecord = "10";
                CreateTempTable(0, int.Parse(cmbNoOfRecords.Text.Trim()));

                btnPrevious.Enabled = true;
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
               
                cmbNoOfRecords.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
                btnLoad.Enabled = true;
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
            if (startRecord == 0 || startRecord < 0)
            {
                btnPrevious.Enabled = false;
                startRecord = 0;
            }
            int endRecord = startRecord + noOfRecords;
            if (endRecord >= totalRecords)
            {
                btnNext.Enabled = false;
                isLastPage = true;
                endRecord = totalRecords;
            }
            currentPageStartRecord = startRecord;
            currentPageEndRecord = endRecord;
            lblPageNums.Text = "Records from " + startRecord + " to "
                + endRecord + " of " + totalRecords;
            currentIndex = endRecord;

            try
            {
                userTable.Rows.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                //adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim());
                adapter.Fill(ds, startRecord, noOfRecords, "Books");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTable = ds.Tables["Books"];
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CreateTempTable(0, int.Parse(cmbNoOfRecords.Text));
            // MessageBox.Show("First Record");
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            isLastPage = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (isLastPage)
            {
                int noc = FindLastPageRecords();
                CreateTempTable((totalRecords - noc - int.Parse(cmbNoOfRecords.Text)),
                    int.Parse(cmbNoOfRecords.Text));
                // MessageBox.Show("Last Record 1");
            }
            else
            {
                CreateTempTable((currentIndex - 2 * (int.Parse(cmbNoOfRecords.Text))),
                    int.Parse(cmbNoOfRecords.Text));
                // MessageBox.Show("Last Record 2");
            }
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            isLastPage = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CreateTempTable(currentIndex, int.Parse(cmbNoOfRecords.Text));
            // MessageBox.Show("Next Record ");
            btnPrevious.Enabled = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int totPages = totalRecords / int.Parse(cmbNoOfRecords.Text);
            int remainingRecs = FindLastPageRecords();

            CreateTempTable(totalRecords - remainingRecs, int.Parse(cmbNoOfRecords.Text));
            //  MessageBox.Show("Last Record ");
            btnPrevious.Enabled = true;
            btnNext.Enabled = false;
            isLastPage = true;
        }
        private int FindLastPageRecords()
        {
            return (totalRecords % int.Parse(cmbNoOfRecords.Text));
        }

        private void btnNoOfPages_Click(object sender, EventArgs e)
        {
            CreateTempTable(0, int.Parse(cmbNoOfRecords.Text.Trim()));
            if (int.Parse(cmbNoOfRecords.Text.Trim()) >= totalRecords)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void drpCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
