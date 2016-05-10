using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_Homework
{/*
Реализовать классы для управления банковскими счетами.
Каждый счет должен иметь номер, владельца, текущую сумму на счету не меньше нуля.

Типы счетов: 
• сберегательный - возможность пополнения и изъятия денег со счета
• накопительный - возможность пополнения и изъятия денег со счета, 
  но не меньше первоначального взноса, наличие процентной ставки, 
  капитализация процентов за месяц
• расчетный - возможность пополнения и изъятия денег со счета, 
  наличие платы за обслуживание, списание суммы за обслуживание со счета
• обезличенный металлический счет - тип металла, количество грамм, 
  стоимость за грамм (текущий курс), возможность пополнять и обналичивать счет по текущему курсу

Реализовать метод закрытия счета.
С закрытым счетом нельзя проводить никакие операции. 
Счет не может быть закрыт, если он имеет положительный баланс.
*/

    class Program
    {
        static void Main(string[] args)
        {
            // Сберегательный
            /* 
             SberAccount mySberSchet = new SberAccount(10001, "Тестовый Тест Тестович",600, true);
             Console.WriteLine(mySberSchet.FormattedValue);
             mySberSchet.AddSumm(10);
             mySberSchet.ExtractSumm(611);
             mySberSchet.CloseAccount();
             mySberSchet.ExtractSumm(610);
             mySberSchet.CloseAccount();
             Console.WriteLine(mySberSchet.FormattedValue);
             */

            // Накопительный
            
            SavingAccount mySavingSchet = new SavingAccount(100, 11 , 1002, "Тестовый Тест Тестович", 600, true);
            Console.WriteLine(mySavingSchet.FormattedValue);
            mySavingSchet.ExtractSumm(110);
            mySavingSchet.ExtractSumm(50);
            mySavingSchet.Capital();
            Console.WriteLine(mySavingSchet.FormattedValue);
            

            // Расчетный
            /*
            CheckingAccount myCheckingSchet = new CheckingAccount(2, 1003, "Тестовый Тест Тестович", 600, true);
            myCheckingSchet.PayForService();
            Console.WriteLine(myCheckingSchet.FormattedValue);
            */

            // Металлический
           /* MetalAccount myMetalSchet = new MetalAccount(1004, true, "Золото", 50, 1500);
            Console.WriteLine(myMetalSchet.FormattedValue);
            myMetalSchet.AddSumm(1500);
            myMetalSchet.ExtractSumm(3000);
            myMetalSchet.ExtractSumm(73501);
            Console.WriteLine(myMetalSchet.FormattedValueMetal);*/


            //  mySberSchet.ExtractSumm(2);
            //  Console.WriteLine(mySberSchet.FormattedValue);

            //Лекция 6
            //Сделать класс Клиент, который может содержать множество счетов (можно взять те, что в ДЗ). 
            //Сделать свойство, отображающее общую сумму денег на всех счетах.
            //Добавить 2 разных счета.

            /*
            Client myClient = new Client();
            myClient.Add(mySchet);
            myClient.Add(myRaschetn);
            Console.WriteLine(myClient.SummAccount());
            */
        }
    }
}
