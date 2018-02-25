using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExcelFile
{
    static class Constants
    {
        #region Common
        public static string OpenFileFilter
        {
            get
            {
                return "Excel 2010|*.xlsx|Excel|*.xls";
            }
        }
        #endregion

        #region MessageBoxVals

        public static string GeneralError
        {
            get
            {
                return "Error";
            }
        }

        public static string ErrorEnterValidInteger
        {
            get
            {
                return "Please Enter a Valid Integer";
            }
        }

        #endregion

        #region excelImportVals

        public static string excelMonthVal
        {
            get
            {
                return "Convert.ToDateTime(importData.Columns[\"Date\"]).ToString(\"MMMM\")";
            }
        }

        public static string excelWeekdayVal
        {
            get
            {
                return "Convert.ToDateTime(importData.Columns[\"Date\"]).ToString(\"dddd\")";
            }
        }

        public static string excelDayOfWeekdayVal
        {
            get
            {
                return "Convert.ToInt32(Convert.ToDateTime(importData.Columns[\"Date\"]).DayOfWeek)";
            }
        }
        #endregion
    }
}
