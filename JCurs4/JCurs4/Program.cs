using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace JCurs4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string text=Console.ReadLine();

            Console.WriteLine("Введите искомое слово:");
            string pattern = @"\b"+Console.ReadLine()+@"\b";
           
            Console.WriteLine("Количество вхождений: {0}", Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count);
            Console.ReadKey();
        }
    }
}
