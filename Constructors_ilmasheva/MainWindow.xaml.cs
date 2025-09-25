using Constructors_ilmasheva.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Constructors_ilmasheva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudents = RepoStudents.AllStudents();

        /// <summary> Количество записей для разовой прогрузки </summary>
        public int Count = 10;
        /// <summary> Шаг на котором находится пользователь </summary>
        public int Step = 0;

        public MainWindow()
        {
            InitializeComponent();
            // Создание студентов
            CreateStudent(Step, Count);
        }

        /// <summary> Метод создания студентов </summary>
        public void CreateStudent(int Step, int Count)
        {
            // Перебираем студентов с шага на котором остановились, до шага + кол-во записей
            for (int iStudent = Step; iStudent < Step + Count; iStudent++)
                // Если индекс не вышел за рамки
                if (AllStudents.Count > iStudent)
                    // Добавляем в интерфейс пользовательский элемент со студентом
                    parent.Children.Add(new Elements.Student(AllStudents[iStudent]));
            // Увеличиваем шаг на кол-во записей
            this.Step += Count;
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            // Получаем элемент прокрутки
            ScrollViewer scroll = sender as ScrollViewer;
            // Получаем высоту списка с элементами
            double ParentHeight = parent.ActualHeight;
            // Получаем высоту окна - 20 пикселей отступ
            double WindowHeight = scroll.ActualHeight - 20;
            // Получаем дельта высоту на которую может сместиться пользователь
            double DeltaHeight = ParentHeight - WindowHeight;
            // Если высота на которую может сместиться пользователь - высота на которую спустился < 140 (2 плашки)
            if (DeltaHeight - scroll.VerticalOffset < 140)
            {
                // Создаём новые
                CreateStudent(Step, Count);
            }
        }
    }
}
