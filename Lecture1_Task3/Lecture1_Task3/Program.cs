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
            int aa = a & (a - 1);
            Console.WriteLine(aa);
            Console.ReadKey();
        }
    }
}
