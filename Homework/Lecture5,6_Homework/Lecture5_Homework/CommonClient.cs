using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    class CommonClient : BankClient
    {
        public CommonClient(string fio) : base(fio)
        {
            Console.WriteLine($"Укажите от 1 до 3 сколько счетов нужно создать для обычного клиента {fio}");
            uint countListAccount = Convert.ToUInt32(Console.ReadLine());
             base.AddAccountInList(countListAccount);
        }

    }
}
