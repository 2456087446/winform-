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
        public MenuUC()
        {
            InitializeComponent();
            //// 自动添加

            //foreach (Control item in Controls)
            //{
            //    item.Click += ChildControl_Click;
            //}

        }
        //子控件全部绑定到 ChildControl_Click
        private void ChildControl_Click(object sender, EventArgs e)
        {
            OnLabelClick(e); // 调用我们自己写的OnLabelClick，触发【自定义LabelClick事件】
        }


        // 声明事件
        public event EventHandler LabelClick;
        protected virtual void OnLabelClick(EventArgs e)
        {
            
            LabelClick?.Invoke(this, e);
        }


        // 手动添加
        // 回调事件
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);

        }
        private void MenuUC_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);

        }


        [Description("这是设置当前菜单名称的属性")]
        public string MenuText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        
    }
}
