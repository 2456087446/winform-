using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自定义事件.Control
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        // 自定义事件
        // ① 声明事件：对外暴露，给外部Form += 订阅
        public event EventHandler LabelClick;
        // ② 配套受保护虚方法：内部用来触发事件，允许子类重写
        protected virtual void OnLabelClick(EventArgs e)
        {
            // 如果外面有人订阅了LabelClick，就执行订阅的所有方法
            LabelClick?.Invoke(this, e);
        }


        // 各自的事件回调自定义事件的虚方法
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);

        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            OnLabelClick(e);

        }
    }
}
