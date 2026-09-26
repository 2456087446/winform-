using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformConnectSqlServer.Models;

namespace WinformConnectSqlServer.DAL
{
    public class UserTDAL
    {
        // DataRow转实体对象
        private static UserTModel RowToModel(DataRow row)
        {
            UserTModel u = new UserTModel();
            u.UserName = row["UserName"].ToString();
            u.PassWord = row["PassWord"].ToString();
            u.NickName = row["NickName"].ToString();
            if (row["Gender"] != DBNull.Value)
                u.Gender = Convert.ToInt32(row["Gender"]);
            else
                u.Gender = null;
            return u;
        }


        // 根据用户名查询用户
        public static UserTModel GetUserByName(string userName)
        {
            string sql = "select UserName,PassWord,NickName,Gender from UserT where UserName=@UserName";
            SqlParameter[] sp = {
                new SqlParameter("@UserName", userName)
            };
            DataTable dt =SqlHelper.ExecuteDataTable(sql, sp);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            return RowToModel(dt.Rows[0]);

        }


        // 用户注册新增数据
        public static bool AddUser(UserTModel u)
        {
            string sql = @"insert into UserT(UserName,PassWord,NickName,Gender) 
                           values(@UserName,@PassWord,@NickName,@Gender)";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName",u.UserName),
                new SqlParameter("@PassWord",u.PassWord),
                new SqlParameter("@NickName",u.NickName),
                new SqlParameter("@Gender",u.Gender)
            };
            int res = SqlHelper.ExecuteNonQuery(sql, paras);
            return res > 0;

        } 


        // 查询所有用户信息 返回list对象集合
        public static List<UserTModel> GetAllUser()
        {
            string sql = "select UserName ,NickName,Gender from UserT";
            List<UserTModel> list = new List<UserTModel>();

            // 接收表
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            foreach(DataRow dr in dt.Rows)
            {
                UserTModel u = new UserTModel();
                u.UserName = dr["UserName"].ToString();
                u.NickName = dr["NickName"].ToString();
                if (dr["Gender"] != DBNull.Value)
                {
                    u.Gender = Convert.ToInt32(dr["Gender"]);
                    u.GenderStr = u.Gender == 1? "男" : "女";
                }
                else
                {
                    u.GenderStr = "未填写";
                }
                list.Add(u);

                // 循环遍历赋值对象字段并且添加到对应的集合中

            }
            return list;
            
        }

        // 查询所有用户信息 返回DataTable（方便编辑）
        public static DataTable GetAllUserDT() {
            string sql = "select UserName,NickName,Gender from UserT";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
            return dt;
        }

        // 更新数据方法
        public static int UpdateUserNick(string userName,string nickName)
        {
            string sql = "UPDATE UserT SET NickName=@NickName WHERE UserName=@UserName";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName", userName),
                new SqlParameter("@NickName", nickName)
            };
            return SqlHelper.ExecuteNonQuery(sql, paras);

        }

    }
}
