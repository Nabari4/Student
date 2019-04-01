using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод данных: ");
            Student Nabar = new Student();
            Nabar.SetInfo();
            Nabar.GetInfo();
            Console.ReadKey();
        }
    }
}
