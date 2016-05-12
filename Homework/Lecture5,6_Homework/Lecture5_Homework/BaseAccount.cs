using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{ 
    public class BaseAccount
    {
        private uint _id;    //Номер счета
        private string _fio; //Владелец
        private decimal _summ;  //Текущая сумма на счете не меньше нуля
        private bool _isActiv; //Статус счета

        public BaseAccount() {  }
        public BaseAccount (uint id,  bool isActiv)
        {
            _id = id;
            _isActiv = isActiv;
        }
        public BaseAccount (uint id, string fio, decimal summ, bool isActiv)
            {
            _id = id;
            _fio = fio;
            _summ = summ;
            _isActiv = isActiv;
            }
        public decimal Summ { get { return _summ;  }}
        public bool Status { get { return _isActiv; } }
        public virtual bool AddSumm(decimal value) //Пополнение счета
        {
            if (_isActiv)
            {
                _summ = _summ + value;
                Console.WriteLine($"Счет пополнен на сумму {value}.Текущая сумма счета: {_summ }");
                return true;         
            }
            else
            {
                Console.WriteLine("Зачисление на счет не произведено, т.к. счет закрыт.");
                return false; //счет закрыт
            }
        }
        public virtual bool ExtractSumm(decimal value) //Списание со счета
        {
            if (_isActiv)
            {
                if (value <= _summ)
                {
                    _summ = _summ - value;
                    Console.WriteLine($"Со счета списана сумма {value}.Текущая сумма счета: {_summ }");
                    return true; 
                }
                else
                {
                    Console.WriteLine($"На счете нет запрашиваемой суммы={value}, т.к. текущий баланс счета={_summ }, списание не произошло.");
                    return false; 
                }
            }
            else
            {
                Console.WriteLine("Списание со счета не произведено, т.к. счет закрыт.");
                return false; 
            }
            
        }

        public bool CloseAccount() //закрытие счета
        {
            if (_summ == 0)
            {
                _isActiv = false;
                Console.WriteLine("Счет успешно закрыт.");
                return true;
            }
            else
            {
                Console.WriteLine($"Счет не закрыт. т.к. для закрытия счета необходим нулевой баланс. Текущий баланс счета = {_summ}");
                return false;
            }
        }
   
        public virtual string FormattedValue 
        {
            get
            {
                return $"Номер счета: {_id}" + "\n" + $"Владелец: {_fio}" + "\n" + $"Сумма: {_summ}" + "\n" + $"Стутс счета: {_isActiv}";
            }
        }
    }
}
