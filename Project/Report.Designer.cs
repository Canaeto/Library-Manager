namespace Project
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgBorrowersDetail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgBookDetail = new System.Windows.Forms.DataGridView();
            this.dtgBorrowedBookReport = new System.Windows.Forms.DataGridView();
            this.tnbRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowersDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowedBookReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borrow Book\'s Report";
            // 
            // dtgBorrowersDetail
            // 
            this.dtgBorrowersDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBorrowersDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBorrowersDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgBorrowersDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBorrowersDetail.Location = new System.Drawing.Point(0, 245);
            this.dtgBorrowersDetail.Name = "dtgBorrowersDetail";
            this.dtgBorrowersDetail.Size = new System.Drawing.Size(819, 170);
            this.dtgBorrowersDetail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book\'s Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Borrowers Detail";
            // 
            // dtgBookDetail
            // 
            this.dtgBookDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBookDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBookDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgBookDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBookDetail.Location = new System.Drawing.Point(0, 473);
            this.dtgBookDetail.Name = "dtgBookDetail";
            this.dtgBookDetail.Size = new System.Drawing.Size(819, 170);
            this.dtgBookDetail.TabIndex = 1;
            // 
            // dtgBorrowedBookReport
            // 
            this.dtgBorrowedBookReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBorrowedBookReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBorrowedBookReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgBorrowedBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBorrowedBookReport.Location = new System.Drawing.Point(-1, 38);
            this.dtgBorrowedBookReport.Name = "dtgBorrowedBookReport";
            this.dtgBorrowedBookReport.Size = new System.Drawing.Size(819, 170);
            this.dtgBorrowedBookReport.TabIndex = 1;
            // 
            // tnbRefresh
            // 
            this.tnbRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tnbRefresh.ForeColor = System.Drawing.Color.White;
            this.tnbRefresh.Location = new System.Drawing.Point(718, 3);
            this.tnbRefresh.Name = "tnbRefresh";
            this.tnbRefresh.Size = new System.Drawing.Size(89, 32);
            this.tnbRefresh.TabIndex = 3;
            this.tnbRefresh.Text = "Refresh";
            this.tnbRefresh.UseVisualStyleBackColor = false;
            this.tnbRefresh.Click += new System.EventHandler(this.tnbRefresh_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tnbRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgBookDetail);
            this.Controls.Add(this.dtgBorrowedBookReport);
            this.Controls.Add(this.dtgBorrowersDetail);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(819, 643);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowersDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowedBookReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgBorrowersDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgBookDetail;
        private System.Windows.Forms.DataGridView dtgBorrowedBookReport;
        private System.Windows.Forms.Button tnbRefresh;

    }
}
