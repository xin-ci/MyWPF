using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoMVVM.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DemoMVVM.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value; }
        }

        public MainWindowViewModel()
        {
            student = new Student();
        }

        private ICommand saveCommand;

        public ICommand SaveCommand => saveCommand ??= new RelayCommand(Save);

        private void Save()
        {
            MessageBox.Show($"需要保存的信息为Id={Student.Id},Name={Student.Name}！");
        }
    }
}