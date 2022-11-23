using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    class BankCheck<T>
    {
        //Создать класс для моделирования счета в банке.
        //Предусмотреть закрытые поля для
        //номера счета,
        //баланса,
        //ФИО владельца.
        //Класс должен быть объявлен как обобщенный.
        //Универсальный параметр T должен определять тип номера счета.
        //Разработать методы  для доступа  к данным  –  заполнения и чтения.

        private T NumChek { get; set; }    
        private string Name { get; set; }
        private decimal Check { get; set; }

        public void Input(T numChek, string name,decimal check)
        {
            NumChek = (T)Convert.ChangeType(numChek,typeof(T));
            this.Name = name;
            this.Check = check;
        }

        public string Info()
        {
            return $"{NumChek} {Name} {Check}";
        }
    }
}
