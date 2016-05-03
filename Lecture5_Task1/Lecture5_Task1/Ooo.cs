using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Task1
{
    class Ooo : Client
    {
        private string _name;
        private int _schet;

        public Ooo(string name, int schet, int id, string phone, int summ) : base(id, phone, summ)
        {
        _name = name;
        _schet = schet;
        }

        public override string FormattedValue
        {
        get
            {
                return $"OOO {_name}   " + base.FormattedValue;
            }
        }

    }
}
