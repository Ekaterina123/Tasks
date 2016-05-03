using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Task2
{
    class Phone
    {
        private string _code;
        private string _phoneNumber;

        public string GetCode
        {
            get { return _code; }
        }

        public string GetPhoneNumber
        {
            get { return _phoneNumber; }
        }

        public Phone(string code, string phoneNumber)
        {
            _code = code;
            _phoneNumber = phoneNumber;
        }


    }
}
