using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new Phone("012","0123456");
            Console.WriteLine($"({p.GetCode}) { p.GetPhoneNumber}");
            
        }
    }
}
