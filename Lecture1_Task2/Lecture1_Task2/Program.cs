using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = ((Convert.ToInt32(Console.ReadLine()) >> Convert.ToInt32(Console.ReadLine())) & 1);
            Console.WriteLine(x);
        }
    }
}
