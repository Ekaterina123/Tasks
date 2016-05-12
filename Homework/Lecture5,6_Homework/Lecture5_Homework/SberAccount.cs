using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{ 
    //сберегательный - возможность пополнения и изъятия денег со счета
  
    public class SberAccount : BaseAccount
    { 


        public SberAccount(uint id, string fio, decimal summ, bool isActiv) : base (id,fio,summ,isActiv)
            {
            }

        public override string FormattedValue
        {
            get
            {
                return "\n" + $"--------Сберегательный счет---------" + "\n" + base.FormattedValue;
            }
        }

    }  
}
