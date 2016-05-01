using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vvedite m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] num1 = new int[n, m];
            Random rnd = new Random();
            int[] min1 = new int[n];

            Console.WriteLine("Massiv [n,m]:");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    num1[i, k] = rnd.Next(0,10);
                    Console.Write(num1[i, k]);
                    Console.Write(",   ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Massiv minimalnix znacheniy [n]:");
            for (int i = 0; i < n; i++)
            {
                min1[i] = num1[i,0];
                for (int k = 0; k < m; k++)
                {
                    if (min1[i] > num1[i, k])
                    {
                        min1[i] = num1[i, k];
                    }
                }
                Console.WriteLine(min1[i]);
            }
            Console.WriteLine("Sort massiv minimalnix znacheniy [n]:");
            Array.Sort(min1);
            for (int k = 0; k <n ; k++)
            {
                Console.WriteLine(min1[k]);
            }
            Console.WriteLine("Sort massiv v obratnom poryadke:");
            for (int k = (n-1); k >=0; k--)
            {
                Console.WriteLine(min1[k]);
            }
        }
    }
}
