using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*Написать регулярное выражение,
определяющее является ли данная
строка GUID с или без скобок. Где
GUID это строчка, состоящая из 8, 4,
4, 4, 12 шестнадцатеричных цифр
разделенных тире. 
– пример правильных выражений:
e02fd0e4 - 00fd - 090A - ca30 -
    0d00a0038ba0.
– пример неправильных выражений:
e02fd0e400fd090Aca300d00a0038ba0.*/
namespace GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "e02fd0e4-00fd-090A-ca30-0d00a0038ba0";
            

            if (str.Regex())
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
            string pattern = @"^[{(]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[)}]?$";
            Match match = System.Text.RegularExpressions.Regex.Match(str, pattern);
            if (match.Success)
            {
                return true;
            }
            else return false;

        }
    }
}
