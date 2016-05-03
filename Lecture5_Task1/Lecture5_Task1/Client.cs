using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Task1
{
    class Client
    {
        private int _id;
        private string _phone;
        private int _summ;

        public Client(int Id, string Phone, int Summ)
        {
            _id = Id;
            _phone = Phone;
            _summ = Summ;
        }

        public virtual string FormattedValue
        {
            get
            {
                return $"Сумма заказа: {_summ}";
            }
        }
    }
}
