using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    /*расчетный - возможность пополнения и изъятия денег со счета, 
     наличие платы за обслуживание, 
     списание суммы за обслуживание со счета */
    class CheckingAccount :BaseAccount
    {
        private uint _payForService;

        public CheckingAccount(uint payForService, uint id, string fio, int summ, bool isActiv) : base (id, fio, summ, isActiv)
        {
            _payForService = payForService;
        }

        public decimal getPayForService { get { return _payForService; } }

        public override string FormattedValue
        {
            get
            {
                return "\n" + $"----------Расчетный счет----------" + "\n" + $"Плата за обслуживание: {_payForService}" + "\n" + base.FormattedValue;
            }
        }

        public bool PayForService()
        {
            return ExtractSumm(getPayForService);
        }

    }
}
