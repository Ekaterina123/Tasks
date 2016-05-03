using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Task1
{
    public class Phone
    {
        private readonly string _code;
        private readonly string _phoneNumber;

        public Phone(string code, string phoneNumber)
        {
            _code = code;
            _phoneNumber = phoneNumber;
        }
        public string PrintPhone()
        {
            if (_code == null || _code == "")
            {
                return _phoneNumber;
            }
            else
            {
                return "(" + _code + ")" + _phoneNumber;
            }
        }
    }
}
