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
using WinformConnectSqlServer.DAL;
using WinformConnectSqlServer.Models;
using WinformConnectSqlServer.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinformConnectSqlServer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //1.拿窗体控件输入
            string userName = this.textBox1.Text;
            string userPwd = this.textBox2.Text;
            //2.实例化BLL，调用BLL的Login方法

            UserTModel loginUser = UserBLL.Login(userName, userPwd);

            //3.UI层处理结果，弹窗、跳转窗体
            if (loginUser != null) {
                //MessageBox.Show("登录成功");
                //跳转到主窗体，把登录用户传递过去
                FormMain main = new FormMain(loginUser);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
            }


        }


        /// <summary>
        /// 注册跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 打开注册窗体
            FormRegist regist = new FormRegist();
            regist.ShowDialog();// ShowDialog：模态弹窗，注册窗口置顶，必须处理完才能回来登录页

        }
    }
}