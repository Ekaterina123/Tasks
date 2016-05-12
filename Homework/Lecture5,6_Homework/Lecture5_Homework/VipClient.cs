using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    
    class VipClient : BankClient
    {
        

        public VipClient(string fio) : base (fio)
        {
            Console.WriteLine($"Укажите от 1 до 10 сколько счетов нужно создать для VIP клиента {fio}");
            uint countListAccount = Convert.ToUInt32(Console.ReadLine());
            base.AddAccountInList(countListAccount);
        }
    }
}
