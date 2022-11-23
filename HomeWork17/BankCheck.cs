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

        private T numChek;
        private string name;
        private decimal check;

        //public void SetName(string value)
        //{
        //    name = value;
        //}

        //public void SetCheck(decimal value) { check = value; }
        //public string Name
        //{
        //    get
        //    { return name; }
        //    set
        //    { name = value; }
        //}

        public void Input(T numChek, string name,decimal check)
        {
            this.numChek = (T)Convert.ChangeType(numChek,typeof(T));
            this.name = name;
            this.check = check;
        }

        public string Info()
        {
            return $"{numChek} {name} {check}";
        }
    }
}
