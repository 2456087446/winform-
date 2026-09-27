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

            //遍历所有一级子控件，绑定鼠标移入移出、鼠标按下
            foreach (Control item in Controls)
            {
                item.MouseEnter += MenuUC_MouseEnter;
                item.MouseLeave += MenuUC_MouseLeave;
                item.MouseDown += MenuUC_MouseDown;
                // ========== Click事件两种实现方式【二选一】 ==========
                // 方式1：foreach批量绑定Click（推荐，简洁，不需要单独写每个控件的Click方法）
                // item.Click += ChildControl_Click;
                // ====================================================
            }
            // 用户控件本身也要绑定鼠标事件（空白区域） 移入移出 按下
            this.MouseEnter += MenuUC_MouseEnter;
            this.MouseLeave += MenuUC_MouseLeave;
            this.MouseDown += MenuUC_MouseDown;
            // 如果开启foreach批量绑定，需要同时开启下面这行
            // this.Click += ChildControl_Click;

        }

        // 鼠标移入：切换悬浮色
        private void MenuUC_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MenuHoverColor;
        }

        // 鼠标移出：恢复常态色，增加坐标判断修复闪烁BUG
        private void MenuUC_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(Cursor.Position)))
            {
                this.BackColor = MenuBaseColor;
            }
        }
        // 鼠标按下（点击按压效果）
        private void MenuUC_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = MenuPressColor;
        }




        //子控件全部绑定到 ChildControl_Click
        private void ChildControl_Click(object sender, EventArgs e)
        {
            OnLabelClick(e); // 调用我们自己写的OnLabelClick，触发【自定义LabelClick事件】
        }

        // 手动声明 添加点击Click事件
        public event EventHandler LabelClick;
        protected virtual void OnLabelClick(EventArgs e)
        {
            LabelClick?.Invoke(this, e);
        }

        // ========== 方式2：手动逐个绑定Click（当前启用，代码保留，适合学习理解） ==========
        // 原理：在窗体设计器，选中控件，在属性窗口事件面板，绑定Click到下面方法
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





        // ========== 自定义属性 ==========
        [Description("这是设置当前菜单名称的属性")]
        public string MenuText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        [Description("图片设置")]
        public Image MenuImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }


        [DefaultValue (typeof(Color),"35,40,45")]
        [Description("菜单默认背景颜色")]
        public Color MenuBaseColor { get; set; } = Color.WhiteSmoke;

        [Description("鼠标移入悬浮背景颜色")]
        public Color MenuHoverColor { get; set; } = Color.LightSteelBlue;

        [Description("鼠标按下点击时背景颜色")]
        public Color MenuPressColor { get; set; } = Color.SteelBlue;

        
    }
}
