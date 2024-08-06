namespace Project
{
    partial class Add_Borrowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Borrowers));
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.drpGender = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblValidateCNIC = new System.Windows.Forms.Label();
            this.phonerror = new System.Windows.Forms.Label();
            this.txtOtherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTotRecords = new System.Windows.Forms.Label();
            this.lblPageNums = new System.Windows.Forms.Label();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.btnNoOfPages = new System.Windows.Forms.Button();
            this.cmbNoOfRecords = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(221, 577);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(668, 87);
            this.txtAddress.TabIndex = 28;
            this.txtAddress.Text = "";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(1227, 236);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(668, 38);
            this.txtFirstName.TabIndex = 16;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(221, 236);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(668, 38);
            this.txtSurname.TabIndex = 15;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(221, 465);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(668, 38);
            this.txtCardNumber.TabIndex = 17;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1227, 346);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(668, 38);
            this.txtPhone.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(688, 677);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(533, 78);
            this.label9.TabIndex = 27;
            this.label9.Text = "Borrower\'s Record";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1219, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 35);
            this.label8.TabIndex = 26;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 532);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 35);
            this.label7.TabIndex = 25;
            this.label7.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1219, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 35);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 35);
            this.label5.TabIndex = 23;
            this.label5.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1219, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 35);
            this.label4.TabIndex = 22;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 35);
            this.label3.TabIndex = 21;
            this.label3.Text = "Surname";
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(8, 689);
            this.prgProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(579, 55);
            this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgress.TabIndex = 8;
            this.prgProgress.Visible = false;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(0, 897);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 102;
            this.userDataGridView.Size = new System.Drawing.Size(2184, 572);
            this.userDataGridView.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(827, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 78);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Borrower\'s";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1632, 644);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(269, 91);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.save_Click);
            // 
            // drpGender
            // 
            this.drpGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpGender.CausesValidation = false;
            this.drpGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drpGender.FormattingEnabled = true;
            this.drpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.drpGender.Location = new System.Drawing.Point(1227, 463);
            this.drpGender.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.drpGender.Name = "drpGender";
            this.drpGender.Size = new System.Drawing.Size(668, 39);
            this.drpGender.TabIndex = 31;
            this.drpGender.Text = "Male";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(752, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 83);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // lblValidateCNIC
            // 
            this.lblValidateCNIC.AutoSize = true;
            this.lblValidateCNIC.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidateCNIC.Location = new System.Drawing.Point(912, 472);
            this.lblValidateCNIC.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblValidateCNIC.Name = "lblValidateCNIC";
            this.lblValidateCNIC.Size = new System.Drawing.Size(86, 35);
            this.lblValidateCNIC.TabIndex = 33;
            this.lblValidateCNIC.Text = "Invaild";
            this.lblValidateCNIC.Visible = false;
            // 
            // phonerror
            // 
            this.phonerror.AutoSize = true;
            this.phonerror.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonerror.Location = new System.Drawing.Point(1917, 355);
            this.phonerror.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.phonerror.Name = "phonerror";
            this.phonerror.Size = new System.Drawing.Size(86, 35);
            this.phonerror.TabIndex = 33;
            this.phonerror.Text = "Invaild";
            this.phonerror.Visible = false;
            // 
            // txtOtherName
            // 
            this.txtOtherName.Location = new System.Drawing.Point(221, 341);
            this.txtOtherName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(668, 38);
            this.txtOtherName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 300);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 35;
            this.label2.Text = "Other Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1227, 582);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(668, 38);
            this.txtEmail.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1219, 532);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 35);
            this.label10.TabIndex = 37;
            this.label10.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1093, 1483);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 55);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(661, 1483);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 55);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "&Add/Update";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(877, 1483);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 55);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "&Commit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1424, 827);
            this.btnLast.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(133, 55);
            this.btnLast.TabIndex = 48;
            this.btnLast.Text = "L&ast";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click_1);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1125, 827);
            this.btnNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 55);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(827, 827);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(133, 55);
            this.btnPrevious.TabIndex = 46;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(528, 827);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(133, 55);
            this.btnFirst.TabIndex = 45;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(528, 758);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 55);
            this.btnLoad.TabIndex = 42;
            this.btnLoad.Text = "&Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTotRecords
            // 
            this.lblTotRecords.AutoSize = true;
            this.lblTotRecords.Location = new System.Drawing.Point(1645, 770);
            this.lblTotRecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotRecords.Name = "lblTotRecords";
            this.lblTotRecords.Size = new System.Drawing.Size(184, 32);
            this.lblTotRecords.TabIndex = 49;
            this.lblTotRecords.Text = "Total Record:";
            // 
            // lblPageNums
            // 
            this.lblPageNums.AutoSize = true;
            this.lblPageNums.Location = new System.Drawing.Point(1645, 842);
            this.lblPageNums.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPageNums.Name = "lblPageNums";
            this.lblPageNums.Size = new System.Drawing.Size(169, 32);
            this.lblPageNums.TabIndex = 50;
            this.lblPageNums.Text = "Page Nums:";
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPages.Location = new System.Drawing.Point(835, 770);
            this.lblNoOfPages.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(349, 32);
            this.lblNoOfPages.TabIndex = 41;
            this.lblNoOfPages.Text = "No. of records per page: ";
            // 
            // btnNoOfPages
            // 
            this.btnNoOfPages.Location = new System.Drawing.Point(1453, 758);
            this.btnNoOfPages.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNoOfPages.Name = "btnNoOfPages";
            this.btnNoOfPages.Size = new System.Drawing.Size(107, 55);
            this.btnNoOfPages.TabIndex = 44;
            this.btnNoOfPages.Text = "&Set";
            this.btnNoOfPages.UseVisualStyleBackColor = true;
            this.btnNoOfPages.Click += new System.EventHandler(this.btnNoOfPages_Click_1);
            // 
            // cmbNoOfRecords
            // 
            this.cmbNoOfRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoOfRecords.FormatString = "N2";
            this.cmbNoOfRecords.FormattingEnabled = true;
            this.cmbNoOfRecords.Items.AddRange(new object[] {
            "15",
            "25",
            "35",
            "45",
            "55"});
            this.cmbNoOfRecords.Location = new System.Drawing.Point(1259, 763);
            this.cmbNoOfRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbNoOfRecords.Name = "cmbNoOfRecords";
            this.cmbNoOfRecords.Size = new System.Drawing.Size(145, 39);
            this.cmbNoOfRecords.TabIndex = 43;
            // 
            // Add_Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPageNums);
            this.Controls.Add(this.lblTotRecords);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNoOfPages);
            this.Controls.Add(this.lblNoOfPages);
            this.Controls.Add(this.cmbNoOfRecords);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOtherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phonerror);
            this.Controls.Add(this.lblValidateCNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.drpGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.userDataGridView);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Add_Borrowers";
            this.Size = new System.Drawing.Size(2184, 1533);
            this.Load += new System.EventHandler(this.Add_Memers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox drpGender;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblValidateCNIC;
        private System.Windows.Forms.Label phonerror;
        private System.Windows.Forms.TextBox txtOtherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTotRecords;
        private System.Windows.Forms.Label lblPageNums;
        private System.Windows.Forms.Label lblNoOfPages;
        private System.Windows.Forms.Button btnNoOfPages;
        private System.Windows.Forms.ComboBox cmbNoOfRecords;
        private System.Windows.Forms.ProgressBar prgProgress;
    }
}
