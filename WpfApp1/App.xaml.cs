using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfLibrary1;
using WpfViewModel;



namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public  IServiceProvider ServiceProvider { get;private set; }
        public new static App Current => (App)Application.Current;
        public App()
        {
            ServiceProvider = CreateServiceProvider();
        }
        private static IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();
     
            services.AddSingleton<WpfVModel>();
            services.AddSingleton<LoginViewModel>();
            //services.AddSingleton<StuVModel>();
            return services.BuildServiceProvider();
        }
    }

}
