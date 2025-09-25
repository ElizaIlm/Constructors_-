using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_ilmasheva.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Scholarship = false;
        public int Course = 4;

        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }


        public Student(string Firstname, string Lastname, string Surname, bool Scholarship)
        : this(Firstname, Lastname, Surname) // Вызов предыдущего конструктора
        {
            this.Scholarship = Scholarship;
        }


        public Student(string Firstname, string Lastname, string Surname, bool Scholarship, int Course)
       : this(Firstname, Lastname, Surname, Scholarship) // Вызов предыдущего конструктора
        {
            this.Course = Course;
        }


        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
    }
}
