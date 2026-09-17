using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace 自定义控件
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            // 所有子控件点击都转发到 UserControl 自身
            // 注册事件：子控件的Click事件，都交给同一个方法 Child_Click 处理
            this.panel1.Click += Child_Click;
            this.label1.Click += Child_Click;
            this.pictureBox1.Click += Child_Click;
        }




        // 【属性】在属性窗口可以看到，用来设置label1的文字
        [Description("菜单项被点击时触发")]
        public string UserControl1Name
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }


        // 子控件点击后进入这个方法
        private void Child_Click(object sender, EventArgs e)
        {
            // 手动调用 UserControl 的 OnClick 方法，触发 UserControl 的 Click事件
            this.OnClick(e);   // 触发 UserControl1 的 Click 事件
            //子控件被点 → 进入 Child_Click → 手动触发 UserControl 的 Click 事件。

            // OnClick代表调用这个控件所有的绑定事件
        }
    }
}