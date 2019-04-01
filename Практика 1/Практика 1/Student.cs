using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    class Student
    {
        public string Name { get; set; } // Имя
        public int Curs { get; set; } //Курс
        public string Pol { get; set; } //Пол
        public Student()
        {
            Name = null;
            Curs = 0;
            Pol = null;
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя: {0} Курс: {1} Пол: {2}", Name, Curs, Pol);
        }
        public void SetInfo()
        {
            Console.WriteLine("Введите имя студента: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите курс студента: ");
            Curs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пол студента: ");
            Pol = Console.ReadLine();
        }
    }
}
