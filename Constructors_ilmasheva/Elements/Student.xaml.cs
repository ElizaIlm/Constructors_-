
using System.Windows.Controls;


namespace Constructors_ilmasheva.Elements
{
    /// <summary>
    /// Логика взаимодействия для Student.xaml
    /// </summary>
    /// <summary> Логика взаимодействия для Student.xaml </summary>
    public partial class Student : UserControl
    {
        /// <summary> Конструктор элемента </summary>
        public Student(Classes.Student student)
        {
            InitializeComponent();

            // В фамилию присваиваем фамилию полученную из Lastname + Firstname + Surname
            tb_fio.Content = student.GetFIO();
            // В стипендию присваиваем получает её студент или нет
            tb_scholarship.Content = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            // В курс присваиваем номер курса
            tb_course.Content = $"Курс: {student.Course}";
        }
    }
}
