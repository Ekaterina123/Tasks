using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int aa = a >> 1;
            a = aa << 1;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
