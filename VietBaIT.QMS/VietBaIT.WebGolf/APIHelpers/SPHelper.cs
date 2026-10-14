using System.Data;
using VietBaIT.WebGolf.APIModels;
using Microsoft.Data.SqlClient;

namespace VietBaIT.WebGolf.APIModels
{
    public class SPHelper
    {
        public class StoreName
        {
            public static string _SPROC = "_tools_GetParams_SPROC";

            public static string ListCustomer = "get_list_customer";
            public static string ListPatient = "get_list_patient";
            public static string ListStaff = "get_list_staff";
            public static string CountCustomer = "count_customer";
            public static string ListAssiginForPayment = "get_list_assign_for_payment";

        }
        public static DataSet ExecuteStoredProcedure(string sqlConnection, string spName, params object[] args)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnection))
            {
                var ds = new DataSet();
                var dt = new DataTable();
                SqlCommand sqlComm = new SqlCommand(StoreName._SPROC, conn);
                sqlComm.Parameters.AddWithValue("@spName", spName);

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(dt);

                sqlComm = new SqlCommand(spName, conn);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var row = dt.Rows[i];
                    var parameter = Utility.sDbnull(row["Parameter_Name"]);
                    var type = Utility.sDbnull(row["Type"]);
                    var length = Utility.Int32Dbnull(row["Length"]);
                    sqlComm.Parameters.AddWithValue(parameter, args[i]);
                }
                sqlComm.CommandType = CommandType.StoredProcedure;

                da.SelectCommand = sqlComm;

                da.Fill(ds);
                return ds;
            }
        }
    }
}
