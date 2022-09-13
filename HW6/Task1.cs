using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    public class Money
    {

        int whole;
        int fractional;
        string symbol;
        int Whole { get; set; }
        int Fractional { get; set; }
        string Symbol { get; set; }

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
}
