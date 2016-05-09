using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{
    class MetalAccount:BaseAccount
    {
        /* обезличенный металлический счет - 
           тип металла, 
           количество грамм, 
           стоимость за грамм (текущий курс), 
           возможность пополнять и обналичивать счет по текущему курсу */      
              
        private string _typeOfMetal;
        private decimal _grammOfMetal;
        private decimal _rate;

        public MetalAccount(uint id, bool isActiv, string typeOfMetal, decimal grammOfMetal, decimal rate): base (id, isActiv)
         {
            _typeOfMetal = typeOfMetal;
            _grammOfMetal = grammOfMetal;
            _rate = rate;
        }

        public decimal CalculateSumm()
        {
            decimal x = 0;
            x = _grammOfMetal * _rate;
            return x;
        }

        public override bool AddSumm(decimal value) //Возможность пополнять счет по текущему курсу
        {
            if (getStatus == true)
            {
                _grammOfMetal = _grammOfMetal + (value/_rate);
                Console.WriteLine($"Счет пополнен на {value}, текущее количество граммов={_grammOfMetal}, тип металла: {_typeOfMetal}");
                return true;
            }
            else
            {
                Console.WriteLine("Зачисление на счет не произведено, т.к. счет закрыт.");
                return false; //счет закрыт
            }
        }
        public override bool ExtractSumm(decimal value) //Возможность обналичивать счет по текущему курсу
        {
            if (getStatus)
            {
                if (value <= CalculateSumm())
                {
                    _grammOfMetal = _grammOfMetal - (value / _rate);
                    Console.WriteLine($"Счет обналичен на сумму={value}. Остаток граммов на счете:{_grammOfMetal}, тип металла: {_typeOfMetal}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"На счете нет запрашиваемой суммы={value}, т.к. текущий баланс счета={CalculateSumm()}, списание не произошло.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Списание со счета не произведено, т.к. счет закрыт.");
                return false;
            }

        }


        public string FormattedValue
        {
            get
            {
                return "\n" + $"----------Металлический счет----------" + "\n" + $"Тип металла: {_typeOfMetal}" + "\n" + $"Колличество граммов:{_grammOfMetal}";
            }
        }

    }
}
