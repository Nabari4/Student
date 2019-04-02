using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Cadry
    {
        public string Name { get; set; }
        public uint Nomer { get; set; }
        public byte Razr { get; set; }
        public Cadry()
        {
            Name = null;
            Nomer = 0;
            Razr = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine("Добавление нового кадра");
            Console.WriteLine("Имя кадра: ");
            Name = Console.ReadLine();
            Console.WriteLine("Номер кадра: ");
            Nomer = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Разряд: ");
            Razr = Convert.ToByte(Console.ReadLine());
        }
        public void SetInfo()
        {
            Console.WriteLine("Имя: {0}, Номер: {1}, Разряд: {2}", Name, Nomer, Razr);
        }
    }
}
