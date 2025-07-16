using CommunityToolkit.Mvvm.ComponentModel; 
namespace Model
{
    public class Student:ObservableObject
    {
        private int id;
        public  int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
    }
}
