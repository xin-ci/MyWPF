using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfViewModel
{
    public class LoginViewModel:ObservableObject
    {
        //创建一个Login对象
        private Login login;

        //属性绑定
        public Login Login
        {
            get => login;
            set => SetProperty(ref login, value);
        }
        //构造函数
        public LoginViewModel()
        {
            //初始化Login对象
            Login = new Login();          
        }
        //创建命令绑定
        private ICommand saveCommmand;
        //属性绑定命令
        public ICommand SaveCommand => saveCommmand ??= new RelayCommand(Save);

        //创建绑定方法
        public void Save()
        {
            //获取连接字符串
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            //显示登录信息
            System.Windows.MessageBox.Show($"用户名：{Login.UserName},密码：{Login.Password},连接字符串：{connStr}");
        }
    }
}
