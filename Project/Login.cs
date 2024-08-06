using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Project
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
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
                    string username = "";
                    connect.Open();
                    cmd.CommandText = "select * from Staff where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            username = reader[0].ToString();
                            //listBox1.Items.Add("ISBN: " + reader[0].ToString());
                            /* listBox1.Items.Add("Title: " + reader[1].ToString());
                             listBox1.Items.Add("Author: " + reader[2].ToString());
                             listBox1.Items.Add("Location: " + reader[3].ToString());
                             listBox1.Items.Add("Copies Available: " + reader[4].ToString());
                             listBox1.Items.Add("Price: " + reader[5].ToString());
                             listBox1.Items.Add("Genre: " + reader[6].ToString());*/
                            Dashboard f2 = new Dashboard();
                            f2.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("User information not correct.");
                    }
                    connect.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            };
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
