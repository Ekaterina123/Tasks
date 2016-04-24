using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] numbers1 = new int[n, n];
            int[,] numbers2 = new int[n, n];
            Random rnd = new Random();
            int[,] sum12 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    numbers1[i, k] = rnd.Next(0, 100);
                    numbers2[i, k] = rnd.Next(0, 100);
                }
            }
            Console.WriteLine("Massiv1:");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine(numbers1[i, k]);
                }
            }
            Console.WriteLine($"");
            Console.WriteLine("Massiv2:");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine(numbers2[i, k]);
                }
            }
            Console.WriteLine($"");

            Console.WriteLine("Summa:");

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    sum12[i, k] = numbers1[i, k] + numbers2[i, k];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine(sum12[i, k]);
                }
            }
        }
    }
}
