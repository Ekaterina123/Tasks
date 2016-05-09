using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    class MetalAccount
    {
        /* обезличенный металлический счет - тип металла, количество грамм, 
           стоимость за грамм (текущий курс), 
           возможность пополнять и обналичивать счет по текущему курсу */


        private static void Dictionary()
        {
            Dictionary<string, uint> Rate = new Dictionary<string, uint>();


        }
            
              
        private string _typeOfMetal;
        private uint _grammOfMetal;
        


        public MetalAccount(string typeOfMetal, uint grammOfMetal, uint rate)
        {
            _typeOfMetal = typeOfMetal;
            _grammOfMetal = grammOfMetal;
            //Rate = rate;
        }

     /*   public string CashOut()
        {
            Value = 
        }*/

    }
}
