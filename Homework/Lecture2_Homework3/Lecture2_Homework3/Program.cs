using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Калькулятор вычисляет: [сложение(+); вычитание(-); умножение (*); деление(/)]");
            Console.WriteLine("Введите левый операнд");
            int a;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                
            }
            
            Console.WriteLine("Введите операцию");
            string virag = Console.ReadLine();
            Console.WriteLine("Введите правый операнд");
            int b = Convert.ToInt32(Console.ReadLine());
            int itog1=0;
            if (virag == "+")
            {
                itog1 = a + b;
                Console.Write("=");
                Console.WriteLine(itog1);
            }
            if (virag == "-")
            {
                itog1 = a - b;
                Console.Write("=");
                Console.WriteLine(itog1);
            }
            if (virag == "*")
            {
                itog1 = a * b;
                Console.Write("=");
                Console.WriteLine(itog1);
            }
            if (virag == "/")
            {
                if (b != 0)
                {
                    itog1 = a / b;
                    Console.WriteLine(itog1);
                }
                else
                {
                Console.WriteLine("На ноль делить нельзя");
            }
            }


        }
    }
}
