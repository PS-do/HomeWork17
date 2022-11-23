using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать несколько экземпляров класса, параметризированного различными типам.
            //Заполнить его поля и вывести на экран информацию об экземпляре класса.
            BankCheck<int> bankCheck_int=new BankCheck<int>() ;
            bankCheck_int.Input(1220111, "Иванов Иван Иванович", (decimal)999.99);
            Console.WriteLine(bankCheck_int.Info());

            BankCheck<string> bankCheck_string = new BankCheck<string>();
            bankCheck_string.Input("A220AAA", "Иванов Иван Иванович", (decimal)999.99);
            Console.WriteLine(bankCheck_string.Info());

            Console.ReadKey();
        }
    }
}
