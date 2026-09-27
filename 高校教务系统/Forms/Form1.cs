using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 高校教务系统.Models;
using 高校教务系统.Pages;
using 高校教务系统.Properties;
using 高校教务系统.UserControls;

namespace 高校教务系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //绑定自定义菜单点击事件

        }

        //private void menuUC1_LabelClick(object sender, EventArgs e)
        //{
        //    panelContent.Controls.Clear();
        //    HomePage homeP = new HomePage();
        //    homeP.Dock = DockStyle.Fill;   // 关键：让页面填满右侧区域

        //    panelContent.Controls.Add(homeP);
        //}

        //private void menuUC2_LabelClick(object sender, EventArgs e)
        //{
        //    panelContent.Controls.Clear();
        //    SettingPage settingP = new SettingPage();
        //    settingP.Dock = DockStyle.Fill;  // 关键

        //    panelContent.Controls.Add(settingP);
        //}



        private void Form1_Load(object sender, EventArgs e)
        {


            // 1. 动态显示隐藏菜单--001
            // 读取外部txt文件菜单数据 决定那些数据隐藏显示
            string path = @"T:\Desktop\C#\Console\winform项目\高校教务系统\AllMenus.txt";
            string menuText = null;


            if (File.Exists(path))
            {
                menuText = File.ReadAllText(path, Encoding.UTF8);
            }
            Console.WriteLine("文件不存在");

            // 序列化
            MenuModel m1 =  new MenuModel();
            m1.MenuText = "123";
            m1.MenuPage = "1212";
            m1.MenuImage = "123";

            string content = JsonConvert.SerializeObject(m1);
            
            // 反序列化
            List<MenuModel> lstmenuModels = JsonConvert.DeserializeObject<List<MenuModel>>(menuText);// 反序列化文本字符串内容


            // 第一步：按 & 分割出【单个菜单】数组
            //string[] menuItems = menuText.Split('&');
            foreach (MenuModel item in lstmenuModels)
            {
                //string[] menuInfo = item.Split(',');
                MenuUC menuUC = new MenuUC();
                menuUC.MenuText = item.MenuText;
                menuUC.MenuImage = GetBitmapFromRess(item.MenuImage);
                menuUC.LabelClick += (newSender, newE) =>
                {
                    // 反射获取根据不同string表示的类
                    Control page = GetClass(item.MenuPage);
                    if (page == null) return;

                    panelContent.Controls.Clear();
                    page.Dock = DockStyle.Fill;
                    panelContent.Controls.Add(page);


                };
                // ==========图片赋值 完整if‑else if==========
                //if (menuInfo[1] == "home")
                //{
                //    menuUC.MenuImage = Resources.home;
                //}
                //else if (menuInfo[1] == "setting")
                //{
                //    menuUC.MenuImage = Resources.setting;
                //}
                //else if (menuInfo[1] == "selection")
                //{
                //    menuUC.MenuImage = Resources.selection;
                //}
                //else if (menuInfo[1] == "about")
                //{
                //    menuUC.MenuImage = Resources.about;
                //}
                //else
                //{
                //    // 找不到匹配资源，置null，MenuUC内部做好null判断，不显示图片
                //    menuUC.MenuImage = null;
                //}

                flowLayoutPanel1.Controls.Add(menuUC);
            }


            // 拖控件使用
            //if (id == "1")
            //{
            //    menuUC1.Visible = true; // 启动后显示这个控件


            //}
            //else if (id == "2")
            //{
            //    menuUC2.Visible = true; // 启动后显示这个控件


            //}
            //else if (id == "3")
            //{
            //    menuUC3.Visible = true; // 启动后显示这个控件


            //}
            //else if (id == "4")
            //{
            //    menuUC4.Visible = true; // 启动后显示这个控件
            //}


            // 代码生成控件使用
            //if (id == "1")
            //{
            //    MenuUC menuUC1 = new MenuUC();
            //    menuUC1.MenuText = "首页";
            //    // 设置基础颜色（你写的RGB 35,40,45）
            //    menuUC1.MenuBaseColor = Color.FromArgb(35, 40, 45);
            //    menuUC1.MenuHoverColor = Color.LightSteelBlue;
            //    menuUC1.MenuPressColor = Color.SteelBlue;
            //    menuUC1.MenuImage = 高校教务系统.Properties.Resources.home;
            //    flowLayoutPanel1.Controls.Add(menuUC1);
            //}
            //else if (id == "2")
            //{
            //    MenuUC menuUC2 = new MenuUC();
            //    menuUC2.MenuText = "设置";
            //    menuUC2.MenuBaseColor = Color.FromArgb(35, 40, 45);
            //    menuUC2.MenuHoverColor = Color.LightSteelBlue;
            //    menuUC2.MenuPressColor = Color.SteelBlue;
            //    menuUC2.MenuImage = 高校教务系统.Properties.Resources.setting;

            //    flowLayoutPanel1.Controls.Add(menuUC2);
            //}
            //else if (id == "3")
            //{
            //    MenuUC menuUC3 = new MenuUC();
            //    menuUC3.MenuText = "选课";
            //    menuUC3.MenuBaseColor = Color.FromArgb(35, 40, 45);
            //    menuUC3.MenuHoverColor = Color.LightSteelBlue;
            //    menuUC3.MenuPressColor = Color.SteelBlue;
            //    menuUC3.MenuImage = Resources.selection;

            //    flowLayoutPanel1.Controls.Add(menuUC3);
            //}
            //else if (id == "4")
            //{
            //    MenuUC menuUC4 = new MenuUC();
            //    menuUC4.MenuText = "关于";
            //    menuUC4.MenuBaseColor = Color.FromArgb(35, 40, 45);
            //    menuUC4.MenuHoverColor = Color.LightSteelBlue;
            //    menuUC4.MenuPressColor = Color.SteelBlue;
            //    menuUC4.MenuImage = 高校教务系统.Properties.Resources.about;

            //    flowLayoutPanel1.Controls.Add(menuUC4);
            //}



        }




        // 反射获取Resources属性
        public Bitmap GetBitmapFromRess(string name)
        {
            Type type = typeof(Resources);
            PropertyInfo prop = type.GetProperty(name, BindingFlags.Static | BindingFlags.NonPublic);
            if (prop != null && prop.PropertyType == typeof(Bitmap)) {
                return (Bitmap)prop.GetValue(null);
            }
            return null;
        }

        public Control GetClass(string className)
        {
            // 获取当前代码所在程序集
            var asm = Assembly.GetExecutingAssembly();
            // 完整类名
            string fullClassName = $"高校教务系统.Pages.{className}";

            Type t = asm.GetType(fullClassName);
            if (t == null) {
                MessageBox.Show($"找不到页面类：{fullClassName}");
                return null;

            }
            // 调用无参构造函数创建实例
            Object pageobj = Activator.CreateInstance(t) as Object;
            return (Control)pageobj;
        }

        // 

        //private void menuUC1_Click(object sender, EventArgs e)
        //{
        //    

        //}
    }
}