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

          //  while (true)
         //   {
                Console.WriteLine("Введите левый операнд:");
                int a;

                if (!(int.TryParse(Console.ReadLine(), out a)))
                {
                    Console.WriteLine("Вы ввели неверный тип данных");
                }
                else
                {
                    Console.WriteLine("Введите операцию");
                    string virag = Console.ReadLine();
                    if (virag == "+" || virag == "-" || virag == "*" || virag == "/")
                    {
                        Console.WriteLine("Введите правый операнд");
                        int b;
                        if (!(int.TryParse(Console.ReadLine(), out b)))
                        {
                            Console.WriteLine("Вы ввели неверный тип данных");
                        }
                        else
                        {
                            if (virag == "+")
                            {
                                Console.Write("=");
                                Console.WriteLine(a + b);
                            }
                            if (virag == "-")
                            {
                                Console.Write("=");
                                Console.WriteLine(a - b);
                            }
                            if (virag == "*")
                            {
                                Console.Write("=");
                                Console.WriteLine(a * b);
                            }
                            if (virag == "/")
                            {
                                if (b != 0)
                                {
                                    Console.WriteLine(a / b);
                                }
                                else
                                {
                                    Console.WriteLine("На ноль делить нельзя");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Операцию необходимо ввести одним из символов: + или - или * или / ");
                    }
                }
          //  }
        }
    }
}
