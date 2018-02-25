using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace ImportExcelFile
{
    static class DataAccess
    {
        public static System.Data.DataTable importExcelFileData(DataGridView dataGridViewName, string fileName)
        {
            string _tabName = "Data";
            string _header = "YES";
            string _conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 xml;HDR={1}'";
            _conStr = string.Format(_conStr, fileName, _header);

            OleDbConnection con = new OleDbConnection(_conStr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + _tabName + "$]", con);
            con.Open();


            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            System.Data.DataTable data = new System.Data.DataTable();
            sda.Fill(data);

            return data;
            //dataGridViewName.DataSource = data;


        }

        public static System.Data.DataTable addCalcTableCols(System.Data.DataTable importData)
        {
            System.Data.DataTable _returnTable = new System.Data.DataTable();
            //_returnTable = importData;

            _returnTable.Columns.Add("Month", typeof(string));
            _returnTable.Columns.Add("Weekday", typeof(string));
            _returnTable.Columns.Add("Date", typeof(string));
            _returnTable.Columns.Add("Day_Of_Week", typeof(Int32));
            _returnTable.Columns.Add("Week_NUM", typeof(Int32));
            _returnTable.Columns.Add("Date_Text", typeof(string));
            _returnTable.Columns.Add("Day_of_Month", typeof(Int32));
            _returnTable.Columns.Add("Run_Miles", typeof(decimal));
            _returnTable.Columns.Add("Bike_Miles", typeof(decimal));
            _returnTable.Columns.Add("Walk_Miles", typeof(decimal));
            _returnTable.Columns.Add("Words", typeof(Int32));
            _returnTable.Columns.Add("Steps", typeof(decimal));
            _returnTable.Columns.Add("Miles_Calc", typeof(decimal));
            _returnTable.Columns.Add("Race_Dates", typeof(string));
            _returnTable.Columns.Add("Race_Type", typeof(string));
            _returnTable.Columns.Add("Race_Times", typeof(string));
            _returnTable.Columns.Add("Official_RT", typeof(string));
            _returnTable.Columns.Add("Run_Times", typeof(string));
            _returnTable.Columns.Add("Run_Min", typeof(Int32));
            _returnTable.Columns.Add("Run_Sec", typeof(Int32));
            _returnTable.Columns.Add("Bike_Time", typeof(string));
            _returnTable.Columns.Add("Bike_Min", typeof(Int32));
            _returnTable.Columns.Add("Bike_Sec", typeof(Int32));
            _returnTable.Columns.Add("Walk_Time", typeof(string));
            _returnTable.Columns.Add("Walk_Min", typeof(Int32));
            _returnTable.Columns.Add("Walk_Sec", typeof(Int32));
            //_returnTable.Columns.Add("Colon_Col", typeof(string));
            //_returnTable.Columns.Add("Walk flag", typeof(string));


            foreach (DataRow row in importData.Rows)
            {

                Char charRange = ':';
                int startIndexMin = 0;
                int endIndexMin = 0;
                int lengthMin = 0;
                int startIndexSec = 0;
                int endIndexSec = 0;
                int lengthSec = 0;

                //startIndex = _runTime.IndexOf(charRange);
                //endIndex = _runTime.LastIndexOf(charRange);
                //length = endIndex - startIndex + 1;

                string _month = Convert.ToDateTime(row["Date"]).ToString("MMMM");
                string _weekday = Convert.ToDateTime(row["Date"]).ToString("dddd");
                DateTime _dt = Convert.ToDateTime(row["Date"]);
                Int32 _dow = Convert.ToInt32(Convert.ToDateTime(row["Date"]).DayOfWeek);
                Int32 _wkNum = IefAppSettings.WeekOfYear(IefAppSettings.CurCulture(), _dt);
                string _dtTxt = Convert.ToDateTime(row["Date"]).ToString();
                Int32 _dayOfMonth = Convert.ToInt32(_dt.ToString("dd", IefAppSettings.CurCulture()));
                decimal _runMiles = Convert.ToDecimal(row["Run_Miles"]);
                decimal _bikeMiles = Convert.ToDecimal(row["Bike_Miles"]);
                decimal _walkMiles = Convert.ToDecimal(row["Walk_Miles"]);
                Int32 _words = Convert.ToInt32(row["Words"]);
                decimal _steps = Convert.ToDecimal(row["Steps"]);
                decimal _milesCalc = (_steps/ActivityData.UserStride);
                string _raceDates = Convert.ToString(row["Race_Dates"]);
                string _raceType = GetRunType(Convert.ToSingle(_runMiles));
                string _raceTime = Convert.ToString(row["Race_Times"]);
                string _officialRaceTime = Convert.ToString(row["Official_RT"]);

                //runtime
                //string _runTime = Convert.ToString(row["Run_Times"]);
                string _runTime = Convert.ToString(row["Run_Times"], IefAppSettings.CurCulture());

                startIndexMin = 0;
                endIndexMin = _runTime.IndexOf(charRange);
                lengthMin = endIndexMin - startIndexMin;
                Int32 _runMin = Convert.ToInt32(_runTime.Substring(startIndexMin, lengthMin));

                startIndexSec = _runTime.IndexOf(charRange) +1;
                endIndexSec = _runTime.Length;
                lengthSec = endIndexSec - startIndexSec;
                Int32 _runSec = Convert.ToInt32(_runTime.Substring(startIndexSec, lengthSec));

                //bike time
                string _bikeTime = Convert.ToString(row["Bike_Time"]);

                startIndexMin = 0;
                endIndexMin = _bikeTime.IndexOf(charRange);
                lengthMin = endIndexMin - startIndexMin;
                Int32 _bikeMin = Convert.ToInt32(_bikeTime.Substring(startIndexMin, lengthMin));

                startIndexSec = _bikeTime.IndexOf(charRange) +1;
                endIndexSec = _bikeTime.Length;
                lengthSec = endIndexSec - startIndexSec;
                Int32 _bikeSec = Convert.ToInt32(_bikeTime.Substring(startIndexSec, lengthSec));

                //walktime
                string _walkTime = Convert.ToString(row["Walk_Time"]);

                startIndexMin = 0;
                endIndexMin = _walkTime.IndexOf(charRange);
                lengthMin = endIndexMin - startIndexMin;
                Int32 _walkMin = Convert.ToInt32(_walkTime.Substring(startIndexMin, lengthMin));

                startIndexSec = _walkTime.IndexOf(charRange) +1;
                endIndexSec = _walkTime.Length;
                lengthSec = endIndexSec - startIndexSec;
                Int32 _walkSec = Convert.ToInt32(_walkTime.Substring(startIndexSec, lengthSec));



                _returnTable.Rows.Add(_month, _weekday, _dt, _dow, _wkNum, _dtTxt, _dayOfMonth, _runMiles, _bikeMiles, _walkMiles, _words, _steps, _milesCalc, _raceDates, _raceType, _raceTime, _officialRaceTime, _runTime, _runMin, _runSec, _bikeTime, _bikeMin, _bikeSec, _walkTime, _walkMin, _walkSec);



            }



            return _returnTable;
        }

        public static void populateDataGridView(DataGridView dataGridViewName, System.Data.DataTable data)
        {
            dataGridViewName.DataSource = data;
        }

        public static string GetRunType(float runMiles)
        {
            string _runType = "";

            if (runMiles >= 30)
            {
                _runType = "Ultra";
                return _runType;
            }
            if (runMiles >= 26.2)
            {
                _runType = "Marathon";
                return _runType;
            }
            if (runMiles >= 18.6)
            {
                _runType = "30K+";
                return _runType;
            }
            if (runMiles >= 15.5)
            {
                _runType = "25K+";
                return _runType;
            }
            if (runMiles >= 13.1)
            {
                _runType = "Half Marathon";
                return _runType;
            }
            if (runMiles >= 12.4)
            {
                _runType = "20K+";
                return _runType;
            }
            if (runMiles >= 9.3)
            {
                _runType = "15K+";
                return _runType;
            }
            if (runMiles >= 6.2)
            {
                _runType = "10K+";
                return _runType;
            }
            if (runMiles >= 4.97)
            {
                _runType = "8K+";
                return _runType;
            }
            if (runMiles >= 3.1)
            {
                _runType = "5K+";
                return _runType;
            }
            if (runMiles > 0)
            {
                _runType = "Less than 5K";
                return _runType;
            }
            else
            {
                _runType = "No Run";
            }

            return _runType;
        }


        public static void ExportToExcel(DataGridView dataGridName)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridName.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridName.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridName.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridName.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }



        public static void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }


    }
}
