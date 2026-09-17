using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录界面
{
    public class GlobalData
    {
        // 1. 私有静态字段，保存唯一实例
        private static GlobalData _instance;

        // 2. 私有构造函数：禁止外面 new GlobalData()，防止创建多个对象
        private GlobalData()
        {

        }

        // 3. 静态属性，获取唯一实例，没有就新建
        public static GlobalData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GlobalData();
                }
                return _instance;
            }
        }

        // ===== 这里放你要共享的全局变量 =====
        public string UserName { get; set; }
        public string UserPwd { get; set; }

        public FrmLogin frmlogin { get; set; }   // 你想写这个
                                        
        }
    }
