using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    public abstract class BankClient 
    {
        /*Реализовать класс Банковский клиент. 
         * Клиенты могут быть 2х типов: обычные и VIP. 
         * Обычные клиенты не могут иметь более 3х счетов, VIP - до 10 счетов. 
         * Реализовать методы создания новых счетов для клиентов, 
         * вывод списка счетов и суммы на счету, закрытие счета по его номеру. */

       /* List<BaseAccount> commonAccounts = new List<BaseAccount>(3);
        List<BaseAccount> vipAccounts = new List<BaseAccount>(10);

        public BankClient() : base()
        {
        }
        public virtual void Add(List<BaseAccount> accounts, BaseAccount a)
        {
            accounts.Add(a);
        }




        public virtual decimal SummAllAccount(List<BaseAccount> accounts)
        {
            decimal summAll = 0;
            for (int i = 0; i < accounts.Count; i++)
            {
                summAll = summAll + accounts[i].Summ;
            }
            //Console.WriteLine($"Общая сумма: { summAll}");
            return summAll;

        }*/
    }
}
