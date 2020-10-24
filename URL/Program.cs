using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
/*Написать регулярное выражение,
определяющее является ли данная
строчка валидным URL адресом. В
данной задаче правильным URL
считаются адреса http и https, явное
указание протокола также может
отсутствовать. Учитываются только
адреса, состоящие из символов, т.е.
IP адреса в качестве URL не
присутствуют при проверке.
Допускаются поддомены, указание
порта доступа через двоеточие, GET
запросы с передачей параметров,
доступ к подпапкам на домене,
допускается наличие якоря через
решетку. Однобуквенные домены
считаются запрещенными.
namespace URL
Запрещены спецсимволы, например
«–» в начале и конце имени домена.
Запрещен символ «_» и пробел в
имени домена. При составлении
регулярного выражения
ориентируйтесь на список
правильных и неправильных
выражений заданных ниже. 
– пример правильных выражений:
http://www.example.com,
http://example.com. 
– пример неправильных выражений:
Just Text, http://a.com.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = "http://www.example.com";           
            if (URL.Regex())
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
            string Pattern = @"^(?:(?:https?|ftp|telnet)://(?:[\w]{2,32}(?::[a-z0-9_-]{2,32})?@)?)?(?:(?:[a-z0-9-]{1,128}\.)+(?:ru|su|com|net|org|mil|edu|arpa|gov|biz|info|aero|inc|name|[a-z]{2})|(?!0)(?:(?!0[^.]|255)[0-9]{1,3}\.){3}(?!0|255)[0-9]{1,3})(?:/[a-z0-9.,_@%&?+=\~/-]*)?(?:#[^ '\ &]*)?$";            
            Match match = System.Text.RegularExpressions.Regex.Match(str, Pattern);
            if (match.Success)
            {
                return true; 
            }
            else return false; 

        }
    }
}
