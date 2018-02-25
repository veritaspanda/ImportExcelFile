using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using System.Configuration;

namespace ImportExcelFile
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnImportExcelFile_Click(object sender, EventArgs e)
        {
            string _fileName = GetImportFile();
            DataTable _data = DataAccess.importExcelFileData(dataGridView1, _fileName);
            _data = DataAccess.addCalcTableCols(_data);
            DataAccess.populateDataGridView(dataGridView1, _data);
        }

        public static string GetImportFile()
        {
            string _filename = "";
            string _path = "";
            string _strFile = "";

            OpenFileDialog _openImportFile = new OpenFileDialog();
            _openImportFile.Filter = Constants.OpenFileFilter;
            _openImportFile.FilterIndex = 1;
            _openImportFile.RestoreDirectory = true;
            _openImportFile.CheckFileExists = true;

            if (_openImportFile.ShowDialog() == DialogResult.OK)
            {
                _filename = System.IO.Path.GetFileName(_openImportFile.FileName);
                _path = System.IO.Path.GetDirectoryName(_openImportFile.FileName);
                _strFile = _path + "\\" + _filename;
                _openImportFile.Dispose();

            }
            else
            {
                _openImportFile.Dispose();
                return _strFile;
            }

            return _strFile;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUserStride_TextChanged(object sender, EventArgs e)
        {
            
            Int32 _defaultInt = 2000;
            if (!Int32.TryParse(txtUserStride.Text, out _defaultInt))
            {
                ActivityData.UserStride = _defaultInt;
                MessageBox.Show(Constants.ErrorEnterValidInteger, Constants.GeneralError, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                ActivityData.UserStride = Convert.ToInt32(txtUserStride.Text, IefAppSettings.CurCulture());

            }
            
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {

            //Export to excel
            DataAccess.ExportToExcel(dataGridView1);


            /*
            //export to CSV
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.FileName = "export.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                DataAccess.ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
            */

        }
    }
}
