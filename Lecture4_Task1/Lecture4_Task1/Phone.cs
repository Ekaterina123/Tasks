using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_Task1
{
    public class Phone
    {
        public readonly string Code;
        public readonly string PhoneNumber;

        public Phone(string code, string phoneNumber)
        {
            Code = code;
            PhoneNumber = phoneNumber;
        }
        public string PrintPhone()
        {
            if (Code == null || Code == "")
            {
                return PhoneNumber;
            }
            else
            {
                return "(" + Code + ")" + PhoneNumber;
            }
        }
    }
}
