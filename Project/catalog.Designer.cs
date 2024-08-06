namespace Project
{
    partial class catalog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(catalog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPageNums = new System.Windows.Forms.Label();
            this.lblTotRecords = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNoOfPages = new System.Windows.Forms.Button();
            this.lblNoOfPages = new System.Windows.Forms.Label();
            this.cmbNoOfRecords = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.drpCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.projectDataSet = new Project.projectDataSet();
            this.projectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPageNums);
            this.panel1.Controls.Add(this.lblTotRecords);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnFirst);
            this.panel1.Controls.Add(this.btnNoOfPages);
            this.panel1.Controls.Add(this.lblNoOfPages);
            this.panel1.Controls.Add(this.cmbNoOfRecords);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.prgProgress);
            this.panel1.Controls.Add(this.drpCategory);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.userDataGridView);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(141, 243);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1959, 1146);
            this.panel1.TabIndex = 15;
            // 
            // lblPageNums
            // 
            this.lblPageNums.AutoSize = true;
            this.lblPageNums.Location = new System.Drawing.Point(1773, 248);
            this.lblPageNums.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPageNums.Name = "lblPageNums";
            this.lblPageNums.Size = new System.Drawing.Size(169, 32);
            this.lblPageNums.TabIndex = 73;
            this.lblPageNums.Text = "Page Nums:";
            // 
            // lblTotRecords
            // 
            this.lblTotRecords.AutoSize = true;
            this.lblTotRecords.Location = new System.Drawing.Point(1773, 176);
            this.lblTotRecords.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotRecords.Name = "lblTotRecords";
            this.lblTotRecords.Size = new System.Drawing.Size(184, 32);
            this.lblTotRecords.TabIndex = 72;
            this.lblTotRecords.Text = "Total Record:";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1552, 234);
            this.btnLast.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(133, 55);
            this.btnLast.TabIndex = 71;
            this.btnLast.Text = "L&ast";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1253, 234);
            this.btnNext.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 55);
            this.btnNext.TabIndex = 70;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(955, 234);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(133, 55);
            this.btnPrevious.TabIndex = 69;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(656, 234);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(133, 55);
            this.btnFirst.TabIndex = 68;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNoOfPages
            // 
            this.btnNoOfPages.Location = new System.Drawing.Point(1581, 165);
            this.btnNoOfPages.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnNoOfPages.Name = "btnNoOfPages";
            this.btnNoOfPages.Size = new System.Drawing.Size(107, 55);
            this.btnNoOfPages.TabIndex = 67;
            this.btnNoOfPages.Text = "&Set";
            this.btnNoOfPages.UseVisualStyleBackColor = true;
            this.btnNoOfPages.Click += new System.EventHandler(this.btnNoOfPages_Click);
            // 
            // lblNoOfPages
            // 
            this.lblNoOfPages.AutoSize = true;
            this.lblNoOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfPages.Location = new System.Drawing.Point(963, 176);
            this.lblNoOfPages.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblNoOfPages.Name = "lblNoOfPages";
            this.lblNoOfPages.Size = new System.Drawing.Size(349, 32);
            this.lblNoOfPages.TabIndex = 64;
            this.lblNoOfPages.Text = "No. of records per page: ";
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
            this.cmbNoOfRecords.Location = new System.Drawing.Point(1387, 169);
            this.cmbNoOfRecords.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbNoOfRecords.Name = "cmbNoOfRecords";
            this.cmbNoOfRecords.Size = new System.Drawing.Size(145, 39);
            this.cmbNoOfRecords.TabIndex = 66;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(656, 165);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(200, 55);
            this.btnLoad.TabIndex = 65;
            this.btnLoad.Text = "&Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(1368, 74);
            this.prgProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(579, 55);
            this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgress.TabIndex = 63;
            this.prgProgress.Visible = false;
            // 
            // drpCategory
            // 
            this.drpCategory.AllowDrop = true;
            this.drpCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpCategory.FormattingEnabled = true;
            this.drpCategory.Items.AddRange(new object[] {
            "",
            "Computer",
            "English",
            "Math",
            "Physics"});
            this.drpCategory.Location = new System.Drawing.Point(181, 14);
            this.drpCategory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.drpCategory.Name = "drpCategory";
            this.drpCategory.Size = new System.Drawing.Size(652, 39);
            this.drpCategory.TabIndex = 35;
            this.drpCategory.SelectedIndexChanged += new System.EventHandler(this.drpCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(24, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Category";
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.GridColor = System.Drawing.Color.White;
            this.userDataGridView.Location = new System.Drawing.Point(77, 327);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 102;
            this.userDataGridView.Size = new System.Drawing.Size(1869, 863);
            this.userDataGridView.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(181, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(280, 76);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 102);
            this.label6.TabIndex = 21;
            this.label6.Text = "Catalog";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 100);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "projectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectDataSetBindingSource
            // 
            this.projectDataSetBindingSource.DataSource = this.projectDataSet;
            this.projectDataSetBindingSource.Position = 0;
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "catalog";
            this.Size = new System.Drawing.Size(2184, 1533);
            this.Load += new System.EventHandler(this.catalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource projectDataSetBindingSource;
        private projectDataSet projectDataSet;
        private System.Windows.Forms.ComboBox drpCategory;
        private System.Windows.Forms.Label lblPageNums;
        private System.Windows.Forms.Label lblTotRecords;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNoOfPages;
        private System.Windows.Forms.Label lblNoOfPages;
        private System.Windows.Forms.ComboBox cmbNoOfRecords;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ProgressBar prgProgress;
    }
}
