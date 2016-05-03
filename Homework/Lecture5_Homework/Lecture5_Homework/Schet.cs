using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{ /*сберегательный - возможность пополнения и изъятия денег со счета
  */
    class Schet
    {
        public uint Id;    //Номер счета
        public string Fio; //Владелец
        public int Summ;  //Текущая сумма на счете не меньше нуля

        public Schet (uint id, string fio, int summ)
            {
            Id = id;
            Fio = fio;
            Summ = summ;
            }
 
        public string AddSumm(int value) //Пополнение счета
            {
            Summ = Summ + value;
            return $"Счет пополнен на сумму {value}.Текущая сумма счета: {Summ }";
            }
        public string ExtractSumm(int value) //Списание со счета
        {
            if (value <= Summ)
            {
                Summ = Summ - value;
                Console.WriteLine($"Со счета списана сумма {value}.Текущая сумма счета: {Summ }");
                return $"Со счета списана сумма {value}.Текущая сумма счета: {Summ }";
            }
            else
            {
                Console.WriteLine($"На счете нет запрашиваемой суммы {value}, списание не произошло. Текущая сумма счета: {Summ }");
                return $"На счете нет запрашиваемой суммы {value}, списание не произошло. Текущая сумма счета: {Summ }";
            }
        }

        public virtual string FormattedValue
        {
            get
            {
                return $"-------------------------"+"\n" + "Номер счета:    {Id}" +"\n" + "Владелец счета: "+Fio + "\n" + "Текущая сумма:  "+Summ; 
             } 
         }

}
}
