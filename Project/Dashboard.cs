using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Login b = new Login();
            this.Close();
            b.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Home.Hom))
            {
                HomeP.Controls.Add(Home.Hom);
                Home.Hom.Dock = DockStyle.Fill;
                Home.Hom.BringToFront();
            }
            else
            {
                Home.Hom.BringToFront();
            }
        }

        private void btnAddBorrowers_Click(object sender, EventArgs e)
        {

            if (!HomeP.Controls.Contains(Add_Borrowers.memb))
            {
                HomeP.Controls.Add(Add_Borrowers.memb);
                Add_Borrowers.memb.Dock = DockStyle.Fill;
                Add_Borrowers.memb.BringToFront();

            }
            else
            {
                Add_Borrowers.memb.BringToFront();
            }

        }
      

        private void HomeP_Paint(object sender, PaintEventArgs e)
        {
            if (!HomeP.Controls.Contains(Home.Hom))
            {
                HomeP.Controls.Add(Home.Hom);
                Home.Hom.Dock = DockStyle.Fill;
                Home.Hom.BringToFront();
            }
            else
            {
                Home.Hom.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(catalog.cata))
            {
                HomeP.Controls.Add(catalog.cata);
                catalog.cata.Dock = DockStyle.Fill;
                catalog.cata.BringToFront();
            }
            else
            {

                catalog.cata.Show();
                catalog.cata.BringToFront();
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Issue.isu))
            {
                HomeP.Controls.Add(Issue.isu);
                Issue.isu.Dock = DockStyle.Fill;
                Issue.isu.BringToFront();
            }
            else
            {
                Issue.isu.BringToFront();
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Return.Ret))
            {
                HomeP.Controls.Add(Return.Ret);
                Return.Ret.Dock = DockStyle.Fill;
                Return.Ret.BringToFront();
            }
            else
            {
                Return.Ret.BringToFront();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Add_book.book))
            {
                HomeP.Controls.Add(Add_book.book);
                Add_book.book.Dock = DockStyle.Fill;
                Add_book.book.BringToFront();
            }
            else
            {
                Add_book.book.BringToFront();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Report.rep))
            {
                HomeP.Controls.Add(Report.rep);
                Report.rep.Dock = DockStyle.Fill;
                Report.rep.BringToFront();
            }
            else
            {
                Report.rep.BringToFront();
            }
            Report rp = new Report();
            // rp.showTables();
            // rp.loadData();
            //rp.Showbook();
            // rp.borowbookdetail();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Dashboard.ActiveForm.Close();
            Application.Exit();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Home.Hom))
            {
                HomeP.Controls.Add(Home.Hom);
                Home.Hom.Dock = DockStyle.Fill;
                Home.Hom.BringToFront();
            }
            else
            {
                Home.Hom.BringToFront();
            }
        }

        private void borrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!HomeP.Controls.Contains(Add_book.book))
            {
                HomeP.Controls.Add(Add_book.book);
                Add_book.book.Dock = DockStyle.Fill;
                Add_book.book.BringToFront();
            }
            else
            {
                Add_book.book.BringToFront();
            }
        }

       

        

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

        private void btnFine_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Return.Ret))
            {
                HomeP.Controls.Add(Fine.Fin);
                Fine.Fin.Dock = DockStyle.Fill;
                Fine.Fin.BringToFront();
            }
            else
            {
                Fine.Fin.BringToFront();
            }
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Issue.isu))
            {
                HomeP.Controls.Add(Issue.isu);
                Issue.isu.Dock = DockStyle.Fill;
                Issue.isu.BringToFront();
            }
            else
            {
                Issue.isu.BringToFront();
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Return.Ret))
            {
                HomeP.Controls.Add(Return.Ret);
                Return.Ret.Dock = DockStyle.Fill;
                Return.Ret.BringToFront();
            }
            else
            {
                Return.Ret.BringToFront();
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Report.rep))
            {
                HomeP.Controls.Add(Report.rep);
                Report.rep.Dock = DockStyle.Fill;
                Report.rep.BringToFront();
            }
            else
            {
                Report.rep.BringToFront();
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Dashboard.ActiveForm.Close();
            //Environment.Exit(1);
            Application.Exit();

        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HomeP.Controls.Contains(Add_book.book))
            {
                HomeP.Controls.Add(Add_book.book);
                Add_book.book.Dock = DockStyle.Fill;
                Add_book.book.BringToFront();
            }
            else
            {
                Add_book.book.BringToFront();
            }
        }

       
    }
}

