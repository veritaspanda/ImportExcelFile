using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelDataReader;
using System.Reflection;
using System.IO;

namespace ImportExcelFile
{
    static class DataAccess
    {
        public static void importExcelFileData(DataGridView dataGridViewName, string fileName)
        {
            String _tabName = "Data";
            string _header = "YES";
            String _conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 xml;HDR={1}'";
            _conStr = string.Format(_conStr, fileName, _header);

            //OleDbConnection con = new OleDbConnection(_conStr);
            //OleDbCommand oconn = new OleDbCommand("Select * From [" + _tabName + "$]", con);
            //con.Open();


            //OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridViewName.DataSource = data;


            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(_conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + _tabName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        //Populate DataGridView.
                        dataGridViewName.DataSource = dt;
                    }
                }
            }
        }


        public static System.Data.DataTable GetExcelData(string location, string sheet, string tableName)
        {
            FileStream stream = File.Open(location, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = null;
            if (location.Contains("xlsx"))
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }
            else
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }

            DataSet result = excelReader.AsDataSet();
            excelReader.Close();

            return result.Tables[tableName];
        }
    }
}
