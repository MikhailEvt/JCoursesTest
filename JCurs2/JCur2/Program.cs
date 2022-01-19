using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCur2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a,b = 0;
            string Rez = "";
            try
            {
               a = uint.Parse(Console.ReadLine());
               b = uint.Parse(Console.ReadLine());
               Rez += "НОД(" + a + ", " + b + ") = " + gcd(a, b)+"\n";
               Rez += "НОК(" + a + ", " + b + ") = " + a * b / gcd(a, b);
                Console.WriteLine(Rez);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный формат");
            }
            Console.ReadLine();
        }

        static public ulong gcd(ulong a, ulong b)
        {
            while (b != 0)
            {
                b = a % (a = b);
            }
            return a;
        }
    }
}
