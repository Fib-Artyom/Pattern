using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Проверить, надежно ли составлен пароль. Пароль считается надежным, если
он состоит из 8 или более символов. Где символом может быть английская
буква, цифра и знак подчеркивания. Пароль должен содержать хотя бы одну
заглавную букву, одну маленькую букву и одну цифру. 
– пример правильных выражений: C00l_Pass, SupperPas1.
– пример неправильных выражений: Cool_pass, C00l.*/

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password = "SupperPas1";            
            if (Password.Regex())
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
            string Pattern = @"^(?=.*\d)(?=^.{8,}$)(?=.*[a-z])(?=.*[A-Z])(?!.*\s)\w*$";
            Match match = System.Text.RegularExpressions.Regex.Match(str, Pattern);
            if (match.Success)
            {
                return true;
            }
            else return false;

        }
    }
}
