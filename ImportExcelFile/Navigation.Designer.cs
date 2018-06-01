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
            this.gridExcelImportView = new System.Windows.Forms.DataGridView();
            this.txtUserStride = new System.Windows.Forms.TextBox();
            this.lblUserStride = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelImportView)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportExcelFile
            // 
            this.btnImportExcelFile.Location = new System.Drawing.Point(342, 10);
            this.btnImportExcelFile.Name = "btnImportExcelFile";
            this.btnImportExcelFile.Size = new System.Drawing.Size(122, 20);
            this.btnImportExcelFile.TabIndex = 0;
            this.btnImportExcelFile.Text = "Import Excel File";
            this.btnImportExcelFile.UseVisualStyleBackColor = true;
            this.btnImportExcelFile.Click += new System.EventHandler(this.btnImportExcelFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(584, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gridExcelImportView
            // 
            this.gridExcelImportView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridExcelImportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridExcelImportView.GridColor = System.Drawing.Color.LightSlateGray;
            this.gridExcelImportView.Location = new System.Drawing.Point(30, 10);
            this.gridExcelImportView.Name = "gridExcelImportView";
            this.gridExcelImportView.Size = new System.Drawing.Size(676, 339);
            this.gridExcelImportView.TabIndex = 2;
            this.gridExcelImportView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtUserStride
            // 
            this.txtUserStride.Location = new System.Drawing.Point(214, 11);
            this.txtUserStride.Name = "txtUserStride";
            this.txtUserStride.Size = new System.Drawing.Size(122, 20);
            this.txtUserStride.TabIndex = 3;
            this.txtUserStride.TextChanged += new System.EventHandler(this.txtUserStride_TextChanged);
            // 
            // lblUserStride
            // 
            this.lblUserStride.Location = new System.Drawing.Point(29, 11);
            this.lblUserStride.Name = "lblUserStride";
            this.lblUserStride.Size = new System.Drawing.Size(122, 20);
            this.lblUserStride.TabIndex = 4;
            this.lblUserStride.Text = "Enter User Stride";
            this.lblUserStride.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Location = new System.Drawing.Point(584, 11);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(122, 20);
            this.btnExportToExcel.TabIndex = 5;
            this.btnExportToExcel.Text = "Export To Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Controls.Add(this.lblUserStride);
            this.panelMenu.Controls.Add(this.btnExportToExcel);
            this.panelMenu.Controls.Add(this.txtUserStride);
            this.panelMenu.Controls.Add(this.btnImportExcelFile);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(784, 42);
            this.panelMenu.TabIndex = 6;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelBody.Controls.Add(this.gridExcelImportView);
            this.panelBody.Controls.Add(this.btnExit);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 42);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(784, 419);
            this.panelBody.TabIndex = 7;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelMenu);
            this.Name = "Navigation";
            this.Text = "Welome to Excel Import!";
            ((System.ComponentModel.ISupportInitialize)(this.gridExcelImportView)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportExcelFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gridExcelImportView;
        private System.Windows.Forms.TextBox txtUserStride;
        private System.Windows.Forms.Label lblUserStride;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBody;
    }
}

