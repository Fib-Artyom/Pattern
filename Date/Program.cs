using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Написать регулярное выражение, определяющее является ли данная строчка
датой в формате dd/mm/yyyy. Начиная с 1600 года до 9999 года. 
– пример правильных выражений: 29 / 02 / 2000, 30 / 04 / 2003, 01 / 01 / 2003.
– пример неправильных выражений: 29 / 02 / 2001, 30 - 04 - 2003, 1 / 1 / 1899.*/

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string Date = "29/02/2001";            
            if (Date.Regex())
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
            string pattern = @"^(?:(?:31(/)(?:0[13578]|1[02]))\1|(?:(?:29|30)(/)(?:0[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(/)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0[1-9]|1\d|2[0-8])(/)(?:(?:0[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
            Match match = System.Text.RegularExpressions.Regex.Match(str, pattern);
            if (match.Success)
            {
                return true;
            }
            else return false;

        }
    }
}
