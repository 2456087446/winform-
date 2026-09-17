using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录界面
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            GlobalData.Instance.frmlogin = frmLogin;
            Application.Run(frmLogin);

        }
    }
}
