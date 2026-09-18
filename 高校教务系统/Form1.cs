using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 高校教务系统.Pages;

namespace 高校教务系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //绑定自定义菜单点击事件
            
        }

        private void menuUC1_LabelClick(object sender, EventArgs e)
        {
            //MessageBox.Show($"点击菜单：{menuUC1.MenuText}");
            //MessageBox.Show("这是Form1订阅的Label事件");
            panelContent.Controls.Clear();
            HomePage homeP = new HomePage(); // 添加控件
            panelContent.Controls.Add( homeP );

        }

        private void menuUC2_LabelClick(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            SettingPage settingP = new SettingPage(); // 添加控件
            panelContent.Controls.Add(settingP);
        }

        //private void menuUC1_Click(object sender, EventArgs e)
        //{
        //    

        //}
    }
}
