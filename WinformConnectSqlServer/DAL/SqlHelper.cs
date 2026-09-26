using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformConnectSqlServer.DAL
{
    public class SqlHelper
    {
        private const string conStr = "Server=DESKTOP-A1CG3L1;Initial Catalog=TestDB2;User ID=sa;Password=111111;";
        
        // 增删改查 返回修改行数
        public static int ExecuteNonQuery(string sql, params object[] args)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (args != null) 
                    {
                        cmd.Parameters.AddRange(args);
                        conn.Open();
                    }
                    return cmd.ExecuteNonQuery();

                }
            }
        }
        // 查询，返回查到的Table表格
        public static DataTable ExecuteDataTable(string sql, params object[] args) {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(conStr)) {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                if (args != null) { 
                    adapter.SelectCommand.Parameters.AddRange(args);
                }
                adapter.Fill(dt);
            }
            return dt;
        }



    }
}
