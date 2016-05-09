using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{ 
    class BaseAccount
    {
        private uint _id;    //Номер счета
        private string _fio; //Владелец
        private int _summ;  //Текущая сумма на счете не меньше нуля
        private bool _isActiv; //Статус счета

        public BaseAccount (uint id, string fio, int summ, bool isActiv)
            {
            _id = id;
            _fio = fio;
            _summ = summ;
            _isActiv = isActiv;
            }
        public int getSumm { get { return _summ;  }}

        public bool IsActivAccount {get; set;}

        public bool AddSumm(int value) //Пополнение счета
        {
            if (IsActivAccount)
            {
                _summ = _summ + value;
                return true;          //$"Счет пополнен на сумму {value}.Текущая сумма счета: {_summ }";
            }
            else
            {
                return false; //счет закрыт
            }
        }
        public bool ExtractSumm(int value) //Списание со счета
        {
            if (IsActivAccount & value <= _summ)
            {
                _summ = _summ - value;
                return true; //$"Со счета списана сумма {value}.Текущая сумма счета: {_summ }";
            }
           else
            {
                return false; //return $"На счете нет запрашиваемой суммы {value} или счет закрыт, списание не произошло.";
            }
        }

        public bool CloseAccount() //закрытие счета
        {
            if (_summ == 0)
            {
                _isActiv = false;
                return true;
            }
            else
            {
                return false;
            }
        }
   

}
}
