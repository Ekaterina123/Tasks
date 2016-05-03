using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Homework2
{
    class Program
    {
        //Считывать с консоли числа, 
        //пока не будет введено число “-1”, 
        //среди введенных чисел вывести все дублирующиеся.

        private static void DisplaySet(HashSet<sbyte> set)
        {
            Console.WriteLine("Дублирующиеся значения:");
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые числа от -128 до 127 через Enter,");
            Console.WriteLine("        для заверщения ввода укажите - 1 ");
            sbyte x;
            List<sbyte> number = new List<sbyte>();
            HashSet<sbyte> duplicateNumber = new HashSet<sbyte>();
            x = Convert.ToSByte(Console.ReadLine());

            while (x != -1)
            {
                if (number.Contains(x))
                {
                    duplicateNumber.Add(x);
                }
                else
                {
                    number.Add(x);
                }
                x = Convert.ToSByte(Console.ReadLine());
            }

            DisplaySet(duplicateNumber);
         }        
    }
}
