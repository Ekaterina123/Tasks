using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers1 = new int[n];
            int i = 0;
            int k = 0;

            for (; i < n; i++ )
            {
                numbers1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(numbers1);
            
            for (; k < n; k++)
            {
                Console.WriteLine(numbers1[k]); 
            }


        }
    }
}
