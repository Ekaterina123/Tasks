using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Task1
{
    class Program
    {

        
        private static int chet(int x)  
            {
            if (x % 2 == 0)
            {
                return x;
            }
            return 0;
            }
            
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = chet(a);
            Console.WriteLine(b);
        }
    }
}
