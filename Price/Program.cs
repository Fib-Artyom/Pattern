using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Есть текст с ценами в рублях.
Извлечь из него цены. 
– пример правильных выражений:
23.78 руб.
– пример неправильных выражений:
22 р., 0.002 руб.*/

namespace Price
{
    class Program
    {
        static void Main(string[] args) 
        {
            string Price = "23.78 руб.";           
            if (Price.Regex())
            {
                Console.WriteLine("true");
            }
            else Console.WriteLine("false");
            Console.ReadKey();
        }
    }
    public static class StringExtension
    {

        public static bool Regex(this string str)
        {
            string Pattern = @"(\w+ |^()| )[\d]+\.[\d]{2} (руб.)";
            Match match = System.Text.RegularExpressions.Regex.Match(str, Pattern);
            if (match.Success)
            {
                return true;
            }
            else return false;

        }
    }
}
