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
            DataAccess.importExcelFileData(dataGridView1, _fileName);
        }

        public static string GetImportFile()
        {
            string _filename = "";
            string _path = "";
            string _strFile = "";

            OpenFileDialog _openImportFile = new OpenFileDialog();
            _openImportFile.Filter = "";
            _openImportFile.FilterIndex = 2;
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
    }
}
