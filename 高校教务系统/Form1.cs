using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校教务系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //绑定自定义菜单点击事件
            menuUC1.LabelClick += MenuUC_LabelClick;
            menuUC2.LabelClick += MenuUC_LabelClick;
            menuUC3.LabelClick += MenuUC_LabelClick;
            menuUC4.LabelClick += MenuUC_LabelClick;
        }

        private void MenuUC_LabelClick(object sender, EventArgs e)
        {
            var menuCtrl = sender as UserControls.MenuUC;
            if (menuCtrl != null)
            {
                MessageBox.Show($"点击菜单：{menuCtrl.MenuText}");
            }
        }
    }
}
