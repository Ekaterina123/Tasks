using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Task1
{
    class Program
    {

        private static int Chet(int x)  
            {
            if (int.TryParse(Console.ReadLine(), out x))
            {
                return x;
            }
            return 0;
            }

        private static decimal NotChet(decimal y)
        {
            if (decimal.TryParse(Console.ReadLine(), out y))
            {
                return y;
            }
            return 0;
        }

        public void PrintInt(int value)
        {
            //  Console.WriteLine("Целое число = " + value);
            Console.Write(value + "  ");
        }

        public void PrintDec(decimal value)
        {
            //  Console.WriteLine("Дробное число = " + value);
            Console.Write(value + "  ");
        }

        public void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                PrintInt(array[i]);
            }
        }

        public void PrintDectArray(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                PrintDec(array[i]);
            }
        }
        //Заполнить массив длиной N случайными числами. 
        //Ввести с консоли число A. 
        //Вывести Yes, если число A есть в массиве, No - в противном случае.

        static void Main(string[] args)
        {
            int n, a;
            Random rnd = new Random(); 
            bool est = false;

            Console.WriteLine("Введите число N:");
            n = Chet(n);

            Console.WriteLine("Введите число А от 0 до 10:");
            a = Chet();
            int[] num1 = new int[n];

            Console.WriteLine("Massiv:"); 
             for (int i = 0; i<n; i++) 
             { 
                 num1[i] = rnd.Next(0,10); 
                 Console.WriteLine(num1[i]); 
             } 
             for (int i = 0; i<n; i++) 
             { 
                 if (num1[i] == a) 
                 { 
                     est = true; 
                     break; 
                 } 
             } 
 

             if (!est) 
             { 
                 Console.WriteLine("No"); 
             } 
             else Console.WriteLine("Yes"); 
 

         } 
        
    }
}
