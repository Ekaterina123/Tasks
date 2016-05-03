using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Task1
{
    class Program
    {   //Реализовать классы для описания клиентов двух типов: 
        //ИП и ООО. Каждый тип клиента имеет идентификатор, 
        //основной телефон, сумма заказа. 
        //У ИП указывается ФИО, дата рождения. 
        //У ООО указывается название, банковский счет. 
        //Реализовать метод, который возвращает отформатированное 
        //название и сумму заказа.

        static void Main(string[] args)
        {
            Ip myIp = new Ip("Иванов","01.01.1980",10001,"8(945)123456",1200000);
            Ooo myOoo = new Ooo("2gis", 98832315, 10002, "8(945)234567", 270000);

            Console.WriteLine(myIp.FormattedValue);
            Console.WriteLine();
            Console.WriteLine(myOoo.FormattedValue);

        }
    }
}
