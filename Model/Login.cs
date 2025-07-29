using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Login:ObservableObject
    {
        private string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }
        private string password;
        public string Password
        {
            get => password;
            set =>SetProperty(ref password, value);
        }
        private int userId;
        public int UserId
        {
            get => userId;
            set => SetProperty(ref userId, value);
        }
        private bool isdel;
        public bool IsDel
        {
            get => isdel;
            set => SetProperty(ref isdel, value);
        }
        private bool isadmin;
        public bool IsAdmin
        {
            get => isadmin;
            set => SetProperty(ref isadmin, value);
        }
        private DateTime createTime;
        public DateTime CreateTime
        {
            get => createTime;
            set => SetProperty(ref createTime, value);
        }



    }
}
