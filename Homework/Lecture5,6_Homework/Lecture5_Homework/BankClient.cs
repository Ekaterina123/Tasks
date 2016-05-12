using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    abstract class BankClient
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
        public BankClient(string fio)
        {
            _fio = fio;
        }

        
        public SberAccount CreateAccount()
        {
            _id++;
           Console.WriteLine($"Введите сумму для счета №{_id} клиента {_fio}");
            _summ = Convert.ToDecimal(Console.ReadLine());
            SberAccount myBaseAccount = new SberAccount(_id, _fio, _summ, true);
             return myBaseAccount;
        }

        public virtual void AddAccountInList(uint countAccount)
        {
            for (int i = 0; i < countAccount; i++)
                _myAccounts.Add(CreateAccount());

        }

        public virtual void PrintListAccounts()
        {
            Console.WriteLine($"Счета клиента {_fio}");
            foreach (var account in _myAccounts)
            {
                Console.WriteLine(PrintListAccounts(account));

            }
        }

        public virtual string PrintListAccounts(SberAccount myAccount)
        {
             return $"Номер счета: {myAccount.Id} Сумма: {myAccount.Summ} Статус счета: {myAccount.Status}";
        }


        public decimal SummAllAccount()//(List<SberAccount> accounts)
           {
               decimal summAll = 0;
               for (int i = 0; i < _myAccounts.Count; i++)
            {
                summAll = summAll + _myAccounts[i].Summ;
            }
               Console.WriteLine($"Общая сумма: { summAll}");
               return summAll;
           }

        public void CloseAccount(uint id) //закрытие счета
        {
            for (int i = 0; i < _myAccounts.Count; i++)
            {              
                   if (_myAccounts[i].Id == id)
                    {
                        _isActiv = false;
                        Console.WriteLine("Счет успешно закрыт.");
                    }                  
                else {Console.WriteLine($"Счет {_myAccounts[i].Id} не найден.");}
                }
            }
        }
    }
