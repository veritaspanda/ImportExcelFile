namespace ImportExcelFile
{
    partial class Navigation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImportExcelFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUserStride = new System.Windows.Forms.TextBox();
            this.lblUserStride = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportExcelFile
            // 
            this.btnImportExcelFile.Location = new System.Drawing.Point(586, 13);
            this.btnImportExcelFile.Name = "btnImportExcelFile";
            this.btnImportExcelFile.Size = new System.Drawing.Size(122, 23);
            this.btnImportExcelFile.TabIndex = 0;
            this.btnImportExcelFile.Text = "Import Excel File";
            this.btnImportExcelFile.UseVisualStyleBackColor = true;
            this.btnImportExcelFile.Click += new System.EventHandler(this.btnImportExcelFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(586, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 339);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtUserStride
            // 
            this.txtUserStride.Location = new System.Drawing.Point(185, 15);
            this.txtUserStride.Name = "txtUserStride";
            this.txtUserStride.Size = new System.Drawing.Size(105, 20);
            this.txtUserStride.TabIndex = 3;
            this.txtUserStride.TextChanged += new System.EventHandler(this.txtUserStride_TextChanged);
            // 
            // lblUserStride
            // 
            this.lblUserStride.Location = new System.Drawing.Point(32, 15);
            this.lblUserStride.Name = "lblUserStride";
            this.lblUserStride.Size = new System.Drawing.Size(122, 20);
            this.lblUserStride.TabIndex = 4;
            this.lblUserStride.Text = "Enter User Stride";
            this.lblUserStride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblUserStride);
            this.Controls.Add(this.txtUserStride);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnImportExcelFile);
            this.Name = "Navigation";
            this.Text = "Welome to Excel Import!";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcelFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserStride;
        private System.Windows.Forms.Label lblUserStride;
    }
}

