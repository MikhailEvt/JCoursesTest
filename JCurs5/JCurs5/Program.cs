using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCurs5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
           
            Console.Write("Введите число: ");
            
            try
            {
                N = Int32.Parse(Console.ReadLine());
                for (int i = 0; i <= N; i++)
                {
                    if (IsPal(i)) Console.WriteLine(i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка.");
            }
            Console.ReadKey();    
            
            
        }

        static bool IsPal(int number)
        {
            int FVal = number,
                SVal = 0;
            while (number > 0)
            {
                SVal = SVal * 10 + number % 10;
                number /= 10;
            }
            
            return FVal == SVal ? true : false;
        }
    }
}
