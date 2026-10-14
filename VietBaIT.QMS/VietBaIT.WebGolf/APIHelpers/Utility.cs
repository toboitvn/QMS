using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using VietBaIT.WebGolf.DBModels;

namespace VietBaIT.WebGolf.APIModels
{
    public class Utility
    {
        public static Logger Log;
        public static LogFactory LogFactory;
        public static SMLink_HaDongContext DBContext;

        private static readonly string[] VietnameseSigns =
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };

        static Utility()
        {
        }

        public static DataTable ObjectToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static DataTable CreateDataTable(Type animaltype)
        {
            DataTable return_Datatable = new DataTable();
            foreach (PropertyInfo info in animaltype.GetProperties())
            {
                return_Datatable.Columns.Add(new DataColumn(info.Name, info.PropertyType));
            }
            return return_Datatable;
        }

        public static DataTable convertStringToDataTable(string data)
        {
            DataTable dataTable = new DataTable();
            bool columnsAdded = false;
            foreach (string row in data.Split('$'))
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (string cell in row.Split('|'))
                {
                    string[] keyValue = cell.Split('~');
                    if (!columnsAdded)
                    {
                        DataColumn dataColumn = new DataColumn(keyValue[0]);
                        dataTable.Columns.Add(dataColumn);
                    }
                    dataRow[keyValue[0]] = keyValue[1];
                }
                columnsAdded = true;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }

        public static DataTable ObjectToDataTable(object o)
        {
            var dt = new DataTable("OutputData");

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            var a = o.GetType();
            var b = o.GetType().GetType();
            return dt;
        }

        public static byte ByteDbnull(object obj)
        {
            try
            {
                return Convert.ToByte(obj);
            }
            catch (Exception)
            {
                return Convert.ToByte(-1);
            }
        }

        /// <summary>
        /// hàm thưucj hiện kiểm tra xem thông tin nếu bytenull
        /// thì trả về giá trị mặc định nếu không 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="DefaultVal"></param>
        /// <returns></returns>
        public static byte ByteDbnull(object obj, object DefaultVal)
        {
            try
            {
                return Convert.ToByte(obj);
            }
            catch (Exception)
            {
                try
                {
                    return Convert.ToByte(DefaultVal);
                }
                catch (Exception)
                {
                    return Convert.ToByte(-1);
                }
            }
        }

        public static string sDbnull(object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }

        public static string sDbnull(object obj, object DefaultVal)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return DefaultVal.ToString();
            }
            else
            {
                return obj.ToString();
            }
        }

        public static Int16 Int16Dbnull(object obj)
        {
            try
            {
                return Convert.ToInt16(obj);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static Int16 Int16Dbnull(object obj, object DefaultVal)
        {
            try
            {
                return Convert.ToInt16(obj);
            }
            catch (Exception)
            {
                try
                {
                    return Convert.ToInt16(DefaultVal);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public static Int32 Int32Dbnull(object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static Int32 Int32Dbnull(object obj, object DefaultVal)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception)
            {
                try
                {
                    return Convert.ToInt32(DefaultVal);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public static Int64 Int64Dbnull(object obj)
        {
            try
            {
                return Convert.ToInt64(obj);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static double DoubletoDbnull(object obj)
        {
            try
            {
                return Convert.ToDouble(obj);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static double DoubletoDbnull(object obj, object DefaultVal)
        {
            try
            {
                return Convert.ToDouble(obj);
            }
            catch (Exception)
            {
                try
                {
                    return Convert.ToDouble(DefaultVal);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
        }

        public static decimal DecimaltoDbnull(object obj)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception)
            {
                return Convert.ToDecimal(-1);
            }
        }

        public static decimal DecimaltoDbnull(object obj, object DefaultVal)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception)
            {
                try
                {
                    return Convert.ToDecimal(DefaultVal);
                }
                catch (Exception)
                {
                    return Convert.ToDecimal(-1);
                }
            }
        }

        public static DateTime DatetimetoDbnull(object obj)
        {
            try
            {
                return Convert.ToDateTime(obj);
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }

        /// <summary>
        ///     Hàm bỏ dấu tiếng Việt
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetUnsignString(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
    }
}
