using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество кадров: ");
            int size_list = Convert.ToInt32(Console.ReadLine());
            CadryList cadry_list = new CadryList(size_list);
            for (int i = 0; i < size_list; i++)
            {
                cadry_list.AddItem();
            }
            Console.Clear();
            for (int i = 0; i < size_list; i++)
            {
                cadry_list[i].GetInfo();
            }

            Console.WriteLine("Введи позицию элемента для удаления: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            cadry_list.RemoveItem(pos);
            foreach (Cadry item in cadry_list)
                Console.WriteLine(item.Name + " " + item.Nomer + " " + item.Razr);

            Console.WriteLine("Введи данные кадра для вставки: ");
            cadry_list.AddItem();
            foreach (Cadry item in cadry_list)
                Console.WriteLine(item.Name + " " + item.Nomer + " " + item.Razr);

            Console.Write("Введи позицию кадра для изменения (всего {0} кадров): ", cadry_list.Length);
            pos = Convert.ToInt32(Console.ReadLine());
            Cadry temp = new Cadry();
            temp.GetInfo();
            cadry_list[pos] = temp;
            foreach (Cadry item in cadry_list)
                Console.WriteLine(item.Name + " " + item.Nomer + " " + item.Razr);
            Console.ReadKey();
        }
    }
}
