using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录界面
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // 点击按钮获取账号 密码
            string userName = txtuser.Text;
            string pwd = txtpwd.Text;

            MessageBox.Show($"账号：{userName}密码：{pwd}");
            // 单例模式传值
            GlobalData.Instance.UserName = userName;
            GlobalData.Instance.UserPwd = pwd;
            // 验证
            if (userName =="111" && pwd == "111")
            {
                MessageBox.Show("登陆成功");
                
                // 构造函数传值
                Index index = new Index(userName);
                
                

                index.Show();



                //Index win2 = new Index();
                //win2.Show();
                

                //FrmLogin frmLogin = new FrmLogin();
                this.Hide();// 隐藏当前实例化对象
                

            }
            else
            {
                MessageBox.Show("登陆失败");

            }

        }
    }
}
