using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformConnectSqlServer.BLL;
using WinformConnectSqlServer.Models;

namespace WinformConnectSqlServer.UI
{
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }

        // 注册点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 封装实体
            UserTModel txtUser = new UserTModel();
            txtUser.UserName = txtUserName.Text;
            txtUser.PassWord =  txtPwd.Text;
            txtUser.NickName = txtNickName.Text;
            // 性别判断
            if (rdoMale.Checked)
            {
                txtUser.Gender = 1;
            }
            else if (rdoFeMale.Checked)
            {
                txtUser.Gender = 0;
            }
            else
            {
                txtUser.Gender = null;//不选性别就是null，数据库允许
            }


            // 2. 调用BLL注册方法
            string msg;
            bool result = UserBLL.Register(txtUser, out msg);
            MessageBox.Show(msg);
            if (result)
            {
                //注册成功，关闭注册窗体，回到登录页
                this.Close();
            }

        }
        //返回登录按钮
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
