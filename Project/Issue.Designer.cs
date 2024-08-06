namespace Project
{
    partial class Issue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Issue));
            this.dtReturnDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtIssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.cbBorrowers = new System.Windows.Forms.ComboBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchISBN = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.add_book1 = new Project.Add_book();
            this.btnLoadAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dtReturnDateTimePicker
            // 
            this.dtReturnDateTimePicker.Location = new System.Drawing.Point(296, 244);
            this.dtReturnDateTimePicker.Name = "dtReturnDateTimePicker";
            this.dtReturnDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.dtReturnDateTimePicker.TabIndex = 17;
            this.dtReturnDateTimePicker.ValueChanged += new System.EventHandler(this.dtReturnDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Return Date";
            // 
            // dtIssueDateTimePicker
            // 
            this.dtIssueDateTimePicker.Location = new System.Drawing.Point(296, 218);
            this.dtIssueDateTimePicker.Name = "dtIssueDateTimePicker";
            this.dtIssueDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.dtIssueDateTimePicker.TabIndex = 16;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Location = new System.Drawing.Point(359, 307);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(120, 43);
            this.btnIssueBook.TabIndex = 20;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Borrower Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Books Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Issue_Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(296, 270);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(255, 20);
            this.txt5.TabIndex = 24;
            this.txt5.TextChanged += new System.EventHandler(this.txt5_TextChanged);
            // 
            // cbBorrowers
            // 
            this.cbBorrowers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBorrowers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBorrowers.DisplayMember = "Member_Name";
            this.cbBorrowers.FormattingEnabled = true;
            this.cbBorrowers.Location = new System.Drawing.Point(296, 191);
            this.cbBorrowers.Name = "cbBorrowers";
            this.cbBorrowers.Size = new System.Drawing.Size(255, 21);
            this.cbBorrowers.TabIndex = 25;
            this.cbBorrowers.ValueMember = "Member_Name";
            this.cbBorrowers.SelectedIndexChanged += new System.EventHandler(this.cbBorrowers_SelectedIndexChanged);
            // 
            // cbBooks
            // 
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(296, 164);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(255, 21);
            this.cbBooks.TabIndex = 26;
            this.cbBooks.SelectedIndexChanged += new System.EventHandler(this.cbBooks_SelectedIndexChanged);
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(576, 166);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(26, 13);
            this.lblIsbn.TabIndex = 27;
            this.lblIsbn.Text = "isbn";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(572, 198);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(51, 13);
            this.lblCardNum.TabIndex = 28;
            this.lblCardNum.Text = "CardNum";
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(99, 386);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(633, 240);
            this.userDataGridView.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "ISBN";
            // 
            // txtSearchISBN
            // 
            this.txtSearchISBN.Location = new System.Drawing.Point(134, 356);
            this.txtSearchISBN.Name = "txtSearchISBN";
            this.txtSearchISBN.Size = new System.Drawing.Size(134, 20);
            this.txtSearchISBN.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 352);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 27);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // add_book1
            // 
            this.add_book1.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_book1.Location = new System.Drawing.Point(373, 38);
            this.add_book1.Name = "add_book1";
            this.add_book1.Size = new System.Drawing.Size(8, 8);
            this.add_book1.TabIndex = 27;
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(372, 352);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(76, 27);
            this.btnLoadAll.TabIndex = 33;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.lblCardNum);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.cbBorrowers);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtReturnDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtIssueDateTimePicker);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Issue";
            this.Size = new System.Drawing.Size(819, 643);
            this.Load += new System.EventHandler(this.Issue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtReturnDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtIssueDateTimePicker;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.ComboBox cbBorrowers;
        private System.Windows.Forms.ComboBox cbBooks;
        private Add_book add_book1;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchISBN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoadAll;
    }
}
