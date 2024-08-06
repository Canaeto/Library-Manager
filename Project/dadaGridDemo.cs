using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class dadaGridDemo : Form
    {
        private string connectionString;
        private string sqlQuery;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataSet ds;
        private DataSet tempDataSet;
        private DataTable userTable;
       // private MySQLInfoEnumerator sqlInfo;
        private MySqlDataReader reader;
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
       // private const string getTablesFromDataBase = "SELECT NAME FROM SYSOBJECTS WHERE TYPE = 'U'";

        public dadaGridDemo()
        {
            InitializeComponent();
            btnLoad.Enabled = true;
            btnUpdate.Enabled = false;
          //  sqlInfo = new SQLInfoEnumerator();
            //grpDataManipulate.Enabled = false;
            grpDataManipulate.Enabled = true;
            // btnLoadSqlServers.Select();
            // btnLoadSqlServers.Focus();
            prgProgress.Minimum = 0;
            prgProgress.Maximum = 200;
            ticker = new System.Timers.Timer();
           // intlDelg = new InternalDelegate(sqlInfo.EnumerateSQLServers);
           // ticker.Elapsed += new ElapsedEventHandler(ticker_Elapsed);
            ticker.Interval = 250;
            cmbNoOfRecords.SelectedIndex = 0;
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cmbNoOfRecords.Enabled = false;
        }

        private void dadaGridDemo_Load(object sender, EventArgs e)
        {
            //btnLoad.Enabled = true;
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
            connection = new MySqlConnection(connectionString);
           // MySqlCommand cmd = new MySqlCommand("", connection);
            command = new MySqlCommand(sqlQuery, connection);
            adapter = new MySqlDataAdapter(command);
            builder = new MySqlCommandBuilder(adapter);
            ds = new DataSet("MainDataSet");
            tempDataSet = new DataSet("TempDataSet");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
            lblLoadedTable.Text = "Loading data from table " + "Borrower Table";
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
                sqlQuery = "SELECT * FROM tbl_borrower";
                SetDataObjects();
                connection.Open();
                ticker.Start();
                adapter.Fill(tempDataSet);
                totalRecords = tempDataSet.Tables[0].Rows.Count;
               
                tempDataSet.Clear();
                tempDataSet.Dispose();
              //  adapter.Fill(ds, 0, 5, cmbTables.Text.Trim());
              //  userTable = ds.Tables[cmbTables.Text.Trim()];
               // adapter.Fill(ds, 0, 5, "tbl_borrower");
                adapter.Fill(ds, "tbl_borrower");
                userTable = ds.Tables["tbl_borrower"];

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
                lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;
                lblTotRecords.Text = "Total records: " + totalRecords;
                CreateTempTable(0, int.Parse(cmbNoOfRecords.Text.Trim()));

                btnPrevious.Enabled = true;
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
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
                prgProgress.Value = 0;
                prgProgress.Update();
                prgProgress.Refresh();
                ticker.Stop();
            }
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
                adapter.Fill(ds, startRecord, noOfRecords, "tbl_borrower");
                //userTable = ds.Tables[cmbTables.Text.Trim()];
                userTable = ds.Tables["tbl_borrower"];
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                userDataGridView.ReadOnly = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                adapter.Update(userTable);
                userDataGridView.ReadOnly = true;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                btnUpdate.Enabled = true;
            }
            finally
            {
                btnAdd.Enabled = true;
                btnLoad.Enabled = true;
                connection.Close();
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete selected record(s)?",
                "Delete Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, false)
                == DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    int cnt = userDataGridView.SelectedRows.Count;
                    for (int i = 0; i < cnt; i++)
                    {
                        if (this.userDataGridView.SelectedRows.Count > 0 &&
                            this.userDataGridView.SelectedRows[0].Index !=
                            this.userDataGridView.Rows.Count - 1)
                        {
                            this.userDataGridView.Rows.RemoveAt(
                               this.userDataGridView.SelectedRows[0].Index);
                        }
                    }

                    adapter.Update(userTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                    btnLoad.Enabled = true;
                }
            }
        }

        /*private void btnLoadSqlServers_Click(object sender, EventArgs e)
        {
            ticker.Start();
            btnLoadSqlServers.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            cmbSqlServers.Items.Clear();
            called = CallFor.SqlServerList;
            intlDelg.BeginInvoke(new AsyncCallback(CallBackMethod), intlDelg);
        }*/

        /*void ticker_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new TimerDelegate(ticker_Elapsed), sender, e);
            }
            else
            {
                if (prgProgress.Value == prgProgress.Maximum)
                {
                    prgProgress.Value = 0;
                }
                else
                {
                    prgProgress.Value += 20;
                }
            }
        }*/

        /*private void btnGetAllDataBases_Click(object sender, EventArgs e)
        {
            if (cmbSqlServers.Items.Count > 0 &&
                txtPassword.Text.Trim().CompareTo(string.Empty) != 0 &&
                txtUserName.Text.Trim().CompareTo(string.Empty) != 0)
            {
                ticker.Start();
                btnGetAllDataBases.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                cmbAllDataBases.Items.Clear();
                sqlInfo.SQLServer = cmbSqlServers.Text.Trim();
                sqlInfo.Username = txtUserName.Text.Trim();
                sqlInfo.Password = txtPassword.Text.Trim();
                MessageBox.Show("You may get the list sql servers if user name and password are not correct.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, 0, false);
                intlDelg = new InternalDelegate(sqlInfo.EnumerateSQLServersDatabases);
                called = CallFor.SqlDataBases;
                intlDelg.BeginInvoke(new AsyncCallback(CallBackMethod), intlDelg);
            }
            else
            {
                MessageBox.Show("No sql servers loaded or user name or password empty...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, false);
            }
        }*/

        /*private void btnGetAllTables_Click(object sender, EventArgs e)
        {
            if (cmbAllDataBases.Text.Trim().CompareTo(string.Empty) != 0)
            {
                btnGetAllTables.Enabled = false;
                this.Cursor = Cursors.WaitCursor;
                StringBuilder connStr = new StringBuilder();
                connStr.Append("Database=");
                connStr.Append(cmbAllDataBases.Text);
                connStr.Append(";Server=");
                connStr.Append(cmbSqlServers.Text);
                connStr.Append(";User=");
                connStr.Append(txtUserName.Text.Trim());
                connStr.Append(";Password=");
                connStr.Append(txtPassword.Text.Trim());
                connStr.Append(";Enlist=false; Asynchronous Processing=true");
                connectionString = connStr.ToString();
                sqlQuery = getTablesFromDataBase;
                SetDataObjects();
                try
                {
                    ticker.Start();
                    connection.Open();
                    command.BeginExecuteReader(new AsyncCallback(CallBackMethod),
                        command, CommandBehavior.CloseConnection);
                    called = CallFor.SqlTables;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    ticker.Stop();
                }
                finally
                {
                    btnGetAllTables.Enabled = true;
                    this.Cursor = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Please select database first.",
                    "No database", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, 0, false);
            }
        }*/

        /*private void CallBackMethod(IAsyncResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AsyncDelegate(CallBackMethod), result);
            }
            else
            {
                try
                {
                    prgProgress.Value = prgProgress.Maximum;
                    switch (called)
                    {
                        case CallFor.SqlServerList:
                            string[] sqlServers = intlDelg.EndInvoke(result);
                            cmbSqlServers.Items.AddRange(sqlServers);
                            if (cmbSqlServers.Items.Count > 0)
                            {
                                cmbSqlServers.Sorted = true;
                                cmbSqlServers.SelectedIndex = 0;
                            }
                            this.Cursor = Cursors.Default;
                            btnLoadSqlServers.Enabled = true;
                            txtUserName.Select();
                            txtUserName.Focus();
                            break;
                        case CallFor.SqlDataBases:
                            string[] sqlDatabases = intlDelg.EndInvoke(result);
                            cmbAllDataBases.Items.AddRange(sqlDatabases);
                            if (cmbAllDataBases.Items.Count > 0)
                            {
                                cmbAllDataBases.Sorted = true;
                                cmbAllDataBases.SelectedIndex = 0;
                            }
                            this.Cursor = Cursors.Default;
                            btnGetAllDataBases.Enabled = true;
                            break;
                        case CallFor.SqlTables:
                            reader = command.EndExecuteReader(result);
                            cmbTables.Items.Clear();
                            while (reader.Read())
                            {
                                cmbTables.Items.Add(reader[0].ToString());
                            }
                            if (cmbTables.Items.Count > 0)
                            {
                                cmbTables.Sorted = true;
                                cmbTables.SelectedIndex = 0;
                                grpDataManipulate.Enabled = true;
                            }
                            else
                            {
                                grpDataManipulate.Enabled = false;
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (called == CallFor.SqlTables)
                    {
                        btnGetAllTables.Enabled = true;
                        this.Cursor = Cursors.Default;
                    }
                    prgProgress.Value = 0;
                    prgProgress.Refresh();
                    ticker.Stop();
                }
            }
        }*/

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CreateTempTable(0, int.Parse(cmbNoOfRecords.Text));
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
            }
            else
            {
                CreateTempTable((currentIndex - 2 * (int.Parse(cmbNoOfRecords.Text))),
                    int.Parse(cmbNoOfRecords.Text));
            }
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            isLastPage = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CreateTempTable(currentIndex, int.Parse(cmbNoOfRecords.Text));
            btnPrevious.Enabled = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int totPages = totalRecords / int.Parse(cmbNoOfRecords.Text);
            int remainingRecs = FindLastPageRecords();

            CreateTempTable(totalRecords - remainingRecs, int.Parse(cmbNoOfRecords.Text));
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
    }
}
