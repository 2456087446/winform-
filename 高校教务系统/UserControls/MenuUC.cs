using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 高校教务系统.UserControls
{
    public partial class MenuUC : UserControl
    {
        [Browsable(true)]
        public event EventHandler LabelClick;
        public MenuUC()
        {
            InitializeComponent();
        }

        [Description("这是设置当前菜单名称的属性")]
        public string MenuText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //安全触发事件，没有订阅者不会报错
            LabelClick?.Invoke(sender, e);
        }
    }
}
