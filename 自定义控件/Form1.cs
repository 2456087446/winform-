using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // 【事件处理方法】绑定到 userControl11 的 Click事件
        private void userControl11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我是自定义控件的事件");
        }
    }
}
