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

        private string _fio;
        private uint _id = 0;
        private decimal _summ;
        private bool _isActiv;
        private List<SberAccount> _myAccounts = new List<SberAccount>();

        //public BankClient(string fio) {  _fio = fio; }

        public BankClient(string fio, List<SberAccount> myAccounts)
        {
            _fio = fio;
            _myAccounts = myAccounts;
        }

        public SberAccount CreateAccount()
        {
            _id++;
            _isActiv = true;
            Console.WriteLine($"Введите сумму для счета №{_id} клиента {_fio}");
            _summ = Convert.ToDecimal(Console.ReadLine());
            SberAccount myBaseAccount = new SberAccount(_id,_fio,_summ, true);
            return myBaseAccount;
        }
        public virtual void AddClient(int _countAccount)
        {
            while (_myAccounts.Count < _countAccount)
            {
                _myAccounts.Add(CreateAccount());
            }
        }

        public virtual string PrintListAccounts
        {
            get
            {
                return $"Номер счета: {_id} Сумма: {_summ} Стутс счета: {_isActiv}";
            }
        }
        public decimal SummAllAccount(List<SberAccount> accounts)
           {
               decimal summAll = 0;
               for (int i = 0; i < accounts.Count; i++)
            {
                summAll = summAll + accounts[i].Summ;
            }
               Console.WriteLine($"Общая сумма: { summAll}");
               return summAll;
           }

        public virtual bool CloseAccount(uint id)
        {
            
            return true;
        }
    }
}
