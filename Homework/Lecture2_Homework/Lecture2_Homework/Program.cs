using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num1 = new int[n];
            Console.WriteLine("Введите число А от 0 до 10:");
            int a = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            bool est = false;

            Console.WriteLine("Massiv:");
            for (int i = 0; i < n; i++)
            {
                num1[i] = rnd.Next(0,10);
                Console.WriteLine(num1[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (num1[i] == a)
                {
                    est = true;
                    break;
                }
            }

            if (!est)
            {
                Console.WriteLine("No");
            }
            else Console.WriteLine("Yes");

        }
    }
}
