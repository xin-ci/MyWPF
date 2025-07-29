using Model;

namespace DAL
{
    /// <summary>
    /// 进行数据库交互
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// 声明一个私有的字段  是一个类型 Student的泛型集合
        /// </summary>
        private List<Student> students;
        /// <summary>
        /// 构造函数初始化数据
        /// </summary>
        public StudentDAL()
        {
            init();
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void init()
        {
            //对私有字段进行实例化 创建空集合实例 
            students = new List<Student>();
            for (int i = 0; i < 30; i++)
            {
                students.Add(
                    new Student
                    {
                        Id = i + 1,
                        Name = $"学生{i + 1}",
                        Age = 18 + (i % 5), // 年龄在18到22之间循环
                        Classes = $"班级{(i % 5) + 1}" // 班级在1到5之间循环
                    }
                    );
            }
          
        }


    }
}
