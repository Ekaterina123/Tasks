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
            int Maximal = 0;
            int Minimal = 0, CountEven = 0, CountNotEven = 0, Composition = 0;
            for (; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                Sum = Sum + a;
                if (Maximal < a)
                {
                    Maximal = a
                }

                if (Minimal > a)
                {
                    Minimal = a
                }
            }
            Console.Write(Sum);
            Console.Write(Maximal);
            Console.Write(Minimal);
            Console.ReadKey();
        }
    }
}
