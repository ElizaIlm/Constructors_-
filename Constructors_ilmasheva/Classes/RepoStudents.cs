using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_ilmasheva.Classes
{
    public class RepoStudents
    {
        /// <summary>
        /// Статический метод, который возвращает коллекцию студентов.
        /// </summary>
        /// <returns>Список студентов</returns>
        public static List<Student> AllStudent()
        {
            // Создаём новую коллекцию
            List<Student> allStudent = new List<Student>();

            // Добавляем студентов
            allStudent.Add(new Student("Болотов", "Евгений", "Олегович"));
            allStudent.Add(new Student("Григорьев", "Роман", "Владимирович"));
            allStudent.Add(new Student("Гудков", "Георгий", "Константинович", false, 3));
            allStudent.Add(new Student("Исыпова", "Алёна", "Александровна", true));
            allStudent.Add(new Student("Иутин", "Павел", "Алексеевич", false, 3));
            allStudent.Add(new Student("Ишимов", "Виктор", "Алексеевич"));
            allStudent.Add(new Student("Калюжный", "Артём", "Евгеньевич"));
            allStudent.Add(new Student("Кусакина", "Полина", "Олеговна", true));
            allStudent.Add(new Student("Ленченков", "Александр", "Дмитриевич"));
            allStudent.Add(new Student("Лесникова", "Мария", "Михайловна", true));
            allStudent.Add(new Student("Лихачева", "Татьяна", "Яковлевна"));
            allStudent.Add(new Student("Мокрушина", "Надежда", "Владимировна", true));
            allStudent.Add(new Student("Мутагаров", "Даниил", "Ринатович"));
            allStudent.Add(new Student("Нарижный", "Данил", "Владленович"));
            allStudent.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3));
            allStudent.Add(new Student("Оборин", "Даниил", "Артёмович"));
            allStudent.Add(new Student("Посадских", "Дарья", "Андреевна"));
            allStudent.Add(new Student("Сторожев", "Денис", "Романович", true));
            allStudent.Add(new Student("Суслов", "Егор", "Владимирович"));
            allStudent.Add(new Student("Токмаков", "Даниил", "Сергеевич", true));
            allStudent.Add(new Student("Тронин", "Александр", "Владиславович"));
            allStudent.Add(new Student("Халилов", "Дамир", "Ринатович"));
            allStudent.Add(new Student("Шестаков", "Дмитрий", "Андреевич"));

            // Возвращаем коллекцию
            return allStudent;
        }
    }
}
