using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformConnectSqlServer.DAL;
using WinformConnectSqlServer.Models;

namespace WinformConnectSqlServer.BLL
{
    public class UserBLL
    {
        // 登陆验证
        public static UserTModel Login(string username, string password)
        {
            // 判断用户输入是否为空
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }
            //不为空 调用数据库查询
            UserTModel user = UserTDAL.GetUserByName(username);
            if (user != null && user.PassWord == password)
            {
                return user;

            }
            return null;
        }


        // 注册逻辑
        public static  bool Register(UserTModel txtuser,out string msg)
        {
            msg = "";
            if (string.IsNullOrWhiteSpace(txtuser.UserName))
            {
                msg = "用户名不能为空！";
                return false;
            }
            if (txtuser.UserName.Length < 3)
            {
                msg = "用户名至少3个字符";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtuser.PassWord))
            {
                msg = "密码不能为空";
                return false;
            }
            if (txtuser.PassWord.Length < 4)
            {
                msg = "密码最少4位";
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtuser.NickName))
            {
                msg = "昵称不能为空";
                return false;
            }

            //查询用户名是否已经存在
            UserTModel existUser = UserTDAL.GetUserByName(txtuser.UserName);
            if (existUser != null)
            {
                msg = "该用户名已经被注册！";
                return false;
            }
            //调用DAL插入数据
            bool ok = UserTDAL.AddUser(txtuser);
            if (ok)
            {
                msg = "注册成功！";
                return true;
            }
            msg = "注册失败，数据库异常";
            return false;



        }


        // 展示数据
        public static List<UserTModel> GetAllUsers() {
            return UserTDAL.GetAllUser();
        }
    }
}
