using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformConnectSqlServer.Models
{
    public class UserTModel
    {
        public string UserName {  get; set; }
        public string PassWord { get; set; }
        public string NickName {  get; set; }
        public int? Gender { get; set; }

        public string GenderStr { get; set; } //中文性别
    }
}
