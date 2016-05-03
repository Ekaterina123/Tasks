using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Task1
{
    class Program
    {
        //Создать класс “Телефон”, который содержит следующие данные:
        //код города, номер телефона, которые не могут быть изменены.
        //Добавить метод, который возвращает строку вида “(999) 999999” 
        //или “999999”, если код города отсутствует.

        static void Main(string[] args)
        {

            Phone p = new Phone("999", "999999");
            Console.WriteLine(p.PrintPhone());
        }
    }
}
