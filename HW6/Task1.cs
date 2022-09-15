using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{

    //    Задание 1
    //Запрограммируйте класс Money(объект класса оперирует одной валютой) для работы с деньгами.
    //В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле
    //для хранения копеек(центы, евроценты, копейки и т.д.).
    //Реализовать методы для вывода суммы на экран, задания значений для частей.
    //На базе класса Money создать класс Product для работы
    //с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
    //Для каждого из классов реализовать необходимые
    //методы и поля.

    public class Money
    {

        int whole; //целое
        int fractional; //дробное
        string symbol; //символ
        public int Whole { get { return whole; } set { whole = value; } }
        public int Fractional { get { return fractional; } set { fractional = value; } }
        public string Symbol { get { return symbol; } set { symbol = value; } }

        public Money()
        {
            whole = 0;
            fractional = 0;
            symbol = "P";
        }

        public Money(string symbol)
        {
            whole = 0;
            fractional = 0;
            Symbol = symbol;
        }

        public Money(int whole, int fractional, string symbol)
        {
            Whole = whole;
            Fractional = fractional;
            Symbol = symbol;            
        }

        public override string ToString()
        {
            return $"{whole},{Fractional} {symbol}";
        }

    }

    public class Product : Money
    {

        string name;
        public string Name { get { return name; } set { name = value; } }
        public Product()
        {

            name = "No name";
            this.Whole = 0;
            this.Fractional = 0;
            this.Symbol = "P";

        }

        public Product(string name, double price, string symbol)
        {

            this.name = name;
            this.Whole = Convert.ToInt32(price);
            this.Fractional = Convert.ToInt32(price * 100) % 100;
            this.Symbol = "P";

        }

        public override string ToString()
        {
            return $"{name} - {Whole},{Fractional} {Symbol}";
        }

        public static int operator +(Product a, int n)
        {
            return a.Whole + n;
        }

        public static int operator -(Product a, int n)
        {
            return a.Whole - n;
        }

    }

}
