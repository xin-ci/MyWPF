
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using System.Windows;
using System.Windows.Input;

namespace WpfLibrary1
{
    public class WpfVModel:ObservableObject
    {
        private Student student;
        public Student Student
        {
            get => student;
            set => SetProperty(ref student, value);
        }
        public WpfVModel()
        {
            Student = new Student ();
        }
        private ICommand saveCommand;
        public ICommand SaveCommand => saveCommand ??= new RelayCommand(Save);
        private void Save()
        {
            MessageBox.Show($"需要保存的信息为Id={Student.Id},Name={Student.Name}！");
        }
    }

}
