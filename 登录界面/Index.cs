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
    public partial class Index : Form
    {
        public Index(string username)
        {
            InitializeComponent();
            label1.Text = "你好构造函数共享传值" + username;
            label2.Text = "你好单例共享传值：" + GlobalData.Instance.UserName;


        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 退出整个程序
            // 接收传过来的值

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = &"你好：{username}";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int danjia = int.Parse(textBox1.Text);
            int shuliang = int.Parse(textBox2.Text);

            int zongjia = danjia * shuliang;
            label5.Text = zongjia.ToString();
        }
    }
}
