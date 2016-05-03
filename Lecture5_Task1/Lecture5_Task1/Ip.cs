using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Task1
{
    class Ip : Client
    {
        private string _fio;
        private string _birthDate; // ??? почитать какой формат

        public Ip(string fio, string birthDate, int id, string phone, int summ) : base(id,phone,summ)
        {
            _fio = fio;
            _birthDate = birthDate;
        } 
        public override string FormattedValue
        {
            get
            {
                return $"ИП {_fio}   " + base.FormattedValue;
            }
        }
    }
}
