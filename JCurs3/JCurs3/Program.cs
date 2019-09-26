using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCurs3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string[] Text = Console.ReadLine().Split(' ');
            Array.Sort(Text);
            Text = Text.Select(t => t.Substring(0, 1).ToUpper() + t.Remove(0, 1)).ToArray();
            Console.WriteLine("Колличество слов в предложении {0}",Text.Length);
            foreach (string t in Text)  Console.Write(t+" ");  
            Console.ReadKey();
        }
    }
}
