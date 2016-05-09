using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    class Client
    {
        public void Add(BaseAccount a)
        {
            accounts.Add(a);
        }


        List<BaseAccount> accounts = new List<BaseAccount>();
       

        public decimal SummAccount()
        {
            decimal summAll = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                summAll = summAll + accounts[i].getSumm;
            }
            //Console.WriteLine($"Общая сумма: { summAll}");
            return summAll;

        }
    }
}
