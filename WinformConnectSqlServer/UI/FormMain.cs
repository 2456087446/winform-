using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformConnectSqlServer.DAL;
using WinformConnectSqlServer.Models;

namespace WinformConnectSqlServer.UI
{
    public partial class FormMain : Form
    {
        // 接收登录用户传值
        public UserTModel CurrentLoginUser { get; set; }
        public FormMain(Models.UserTModel loginUser)
        {
            InitializeComponent();
            CurrentLoginUser = loginUser; // 传值 
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            //水平居中
            label3.Left = (this.ClientSize.Width - label3.Width) / 2;
            

            //拿到传过来的用户，显示欢迎信息
            if (CurrentLoginUser != null)
            {
                string genderText = CurrentLoginUser.Gender == 1 ? "男" : CurrentLoginUser.Gender == 0 ? "女" : "未填写";
                showUserName.Text = $"🎉 欢迎你，{CurrentLoginUser.NickName}！\r\n\r\n用户名：{CurrentLoginUser.UserName} ｜性别：{genderText}";
         }



            //加载表格数据
            //List<UserTModel> users = UserTDAL.GetAllUser();
            //dgvData.DataSource = users;
            DataTable dt =  UserTDAL.GetAllUserDT();
            dgvData.DataSource = dt;

            //隐藏不需要的列
            //dgvData.Columns["PassWord"].Visible = false;
            //dgvData.Columns["Gender"].Visible = false;

            //修改表头中文
            dgvData.Columns["UserName"].HeaderText = "用户名";
            dgvData.Columns["NickName"].HeaderText = "昵称";
            //dgvData.Columns["GenderStr"].HeaderText = "性别";

            //表格美化
            dgvData.ReadOnly = false;
            dgvData.AllowUserToAddRows = false;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.RowHeadersVisible = false;
            dgvData.Columns["UserName"].ReadOnly = true; //用户名禁止修改！
        }

        //主窗体关闭事件，退出整个程序（解决登录页Hide后台驻留）
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        // 保存按钮
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dgvData.DataSource as DataTable;
            int successCount =0;
            foreach (DataRow row in dt.Rows) {
                string uname = row["UserName"].ToString();
                string nick = row["NickName"].ToString();

                // 调用DAL
                int res = UserTDAL.UpdateUserNick(uname, nick);
                if (res > 0) { 
                    successCount++;
                }
            }
            MessageBox.Show($"保存完成！成功更新{successCount}条用户");
            //保存完成，刷新表格，从数据库拿最新数据
            dt = UserTDAL.GetAllUserDT();
            dgvData.DataSource = dt;

        }
        // 刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 保存好刷新表格
            DataTable dt = UserTDAL.GetAllUserDT();
            dgvData.DataSource = dt;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //关闭当前主窗体
            this.Close();

            //打开登录窗口
            FormLogin login = new FormLogin();
            login.Show();
        }

        
    }
}
