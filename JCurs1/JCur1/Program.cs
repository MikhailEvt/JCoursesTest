using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCur1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Val=0;
            try
            {
                Console.WriteLine("Введите число: ");
                Val = uint.Parse(Console.ReadLine());
                Console.WriteLine(Pr(Val));
                
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный формат");
            }
            Console.ReadKey();

        }
       static string Pr(uint Val)
        {   
            
            string Rez = "Введенное число ";
            Rez += Val % 2 == 0 ? "четное, " : "нечетное, ";
            if (Val == 0 || Val == 1) Rez += "не простое и не составное.";
            else Rez += IsPrime(Val) ? "простое." : "составное.";
            return Rez;
        }

        static public bool IsPrime(uint n)
        {
            bool prime = true;
            for (uint i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    prime = false;
            }
            return prime;
        }


    }
}
