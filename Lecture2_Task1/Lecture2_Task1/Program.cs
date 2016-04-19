using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, Sum = 0;
            int max = 0;
            int Minimal = 0, CountEven = 0, CountNotEven = 0, Composition = 1;
            for (; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    max = a;
                    Minimal = a;
                }

                if (max < a)
                {
                    max = a;
                }

                if (Minimal > a)
                {
                    Minimal = a;
                }
                if (a % 2 == 0)
                {
                    CountEven++;
                }
                if (a % 2 == 1)
                {
                    CountNotEven++;
                    Composition = Composition * a;  
                }
                Sum = Sum + a;
            }
            Console.Write("Сумма:");
            Console.Write(Sum);
            Console.ReadKey();
            Console.Write("Максимальное значение:");
            Console.Write(max);
            Console.ReadKey();
            Console.Write("Минимальное значение:");
            Console.Write(Minimal);
            Console.ReadKey();
            Console.Write("Количество четных чисел:");
            Console.Write(CountEven);
            Console.ReadKey();
            Console.Write("Количество нечетных чисел:");
            Console.Write(CountNotEven);
            Console.ReadKey();
            if (Composition ==1)
            {
                Console.Write("Произведение нечетных чисел: не было веедено ни одного нечетного числа");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Произведение нечетных чисел:");
                Console.Write(Composition);
                Console.ReadKey();

            }

        }
    }
}
