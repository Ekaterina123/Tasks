using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_Homework1
{
    class Program
    {
        // Считать строку с консоли.Создать словарь, 
        // где ключом будет символ строки, а значением - 
        // количество данных символов в считанной строке.


        private static string GetStr()
        {
            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();
            return value;
        }



        private static void Dictionary()
        {
            Dictionary<char, int> D = new Dictionary<char, int>();
            string a = GetStr();
            int n = a.Length;

            for (int i = 0; i < n; i++)
            {
                if (D.ContainsKey(a[i]))
                {
                    D[a[i]] = D[a[i]] + 1;
                }
                else
                {
                    D.Add(a[i], 1);
                }
            }
            Console.WriteLine("Сформирован словарь:");
            foreach (KeyValuePair<char, int> kvp in D)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }  
    static void Main(string[] args)
        {
            Dictionary();
            
        }
    }
}
