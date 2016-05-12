using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    /*накопительный - возможность пополнения и изъятия денег со счета,
     но не меньше первоначального взноса, 
     наличие процентной ставки,
     капитализация процентов за месяц
    */
    class SavingAccount : BaseAccount
    {
        private uint _firstDeposit;
        private decimal _percent;

        public SavingAccount(uint firstDeposit, decimal percent,  uint id, string fio, int summ, bool isActiv) : base (id,fio,summ, isActiv)
        {
            _firstDeposit = firstDeposit;
            _percent = percent;
        }

        
        public override string FormattedValue
        {
            get
            {
                return "\n" + $"----------Накопительный счет----------" + "\n" + $"Размер первоначального взноса: {_firstDeposit}" + "\n" + $"Процентная ставка: {_percent}" + "\n"  + base.FormattedValue;
            }
        }

        public override bool ExtractSumm(decimal value) //5.	Если остаток на счете меньше первоначального взноса...
        {
            decimal x = 0;
            x = Summ - value;
            if (x <= _firstDeposit)
            {
                return base.ExtractSumm(value);
            }
            else
            {
                Console.WriteLine("Для накопительного счета списываемая сумма должна быть не меньше первоначального взноса");
                Console.WriteLine($"Сумма первоначального взноса={_firstDeposit}, вы пытаетесь списать {value}. Списание не произошло.");
                return false;

            }
        }

        public bool Capital()
        {
            decimal a = ((Summ * (_percent/100)) / 12);
            Console.WriteLine(a);
            AddSumm((Summ * (_percent/100)) / 12);
            return true;
        }


    }
}
