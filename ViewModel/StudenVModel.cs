using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using System.Windows.Input;
using System.Windows;
using System.Windows.Forms; // 添加此命名空间以解决 MessageBox 的问题

namespace ViewModel
{
    public class StudenVModel : ObservableObject
    {
        private Student student;
        public Student Student
        {       
            get { return student; }
            set { Student = value; }
        }   
        public StudenVModel()
        {
            student = new Student();           
        }
        private ICommand saveCommand;
        public ICommand SaveCommand=> saveCommand ??= new RelayCommand(Save);
        private void Save()
        {
            MessageBox.Show($"需要保存的信息为Id={Student.Id},Name={Student.Name}！");
        }
    }
}
