using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform界面开发入门
{
    public partial class Form1 : Form
    {
        // 添加控件

        // 1. 创建button类创建实例
        Button button2 = new Button();
        public Form1()
        {
            InitializeComponent();// 界面初始化方法 跳转到界面设计文件

            //通过在后台主界面初始化时添加按钮控件
            //Button btn = new Button();
            // btn.Text = "你好";
            // btn.Left = 10;
            // btn.Top = 20;

            // this.Controls.Add(btn);

            int x = 0;
            int y = 0;
            for (int i = 0; i < 5; i++)
            {
                Button button2 = new Button();
                x += 20;
                y += 20;
                // 2. 设置属性
                button2.Location = new Point(x, y);// 位置
                button2.Size = new Size(50, 50);// 大小
                button2.Text = "我是代码生成的按钮";
                //button2.Name = "btn2";
                // 3. 界面添加button2
                this.Controls.Add(button2);
                button2.Click += new System.EventHandler(this.button2_Click);

            }

            // 2. 设置属性
            button2.Location = new Point(10,10);// 位置
            button2.Size = new Size(189,88);// 大小
            button2.Text = "我是代码生成的按钮";
            //button2.Name = "btn2";
            // 3. 界面添加button2
            this.Controls.Add(button2);

            // 4. 点击事件绑定添加
            button2.Click += new System.EventHandler(this.button2_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            button1.Text = "OK";
            //button1_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.button2.Text = "OewqeK";
            
            Button btn = sender as Button;
            btn.Text = "123";
        }



    }
}
