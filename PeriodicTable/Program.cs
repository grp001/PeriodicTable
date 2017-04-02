using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var element = "Tullium";
            var symbol = "Tu";
            var result = IsValid(element, symbol);

            Console.ReadKey();
        }

        public static bool IsValid(string element, string symbol)
        {
            bool valid = false;
            int maxSymbols = 2;

            if (string.IsNullOrEmpty(element))
                return valid;

            if (string.IsNullOrEmpty(symbol) || symbol.Length != maxSymbols)
                return valid;

            var index = -1;
            var characters = symbol.ToLower().ToArray();
            foreach (var character in characters)
            {
                int postion = index > -1 ? index + 1 : 0;
                if (postion >= element.Length)
                    break;

                var temp = element.ToLower().IndexOf(character, postion);
                if (temp < 0)
                    break;

                if (index > -1 && temp > index)
                    valid = true;

                index = temp;
            }

            return valid;
        }
    }
}
