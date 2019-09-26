using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCurs6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int M, N;
                Console.Write("Введите грузоподъемность рюкзака: ");
                M = Int32.Parse(Console.ReadLine());
                Console.Write("Введите колличество вещей: ");
                N = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите характеристики вещей в формате стоимость вес ");
                (int c, int m)[] cm = new (int, int)[N + 1];
                for (int j = 1; j <= N; j++)
                {
                    Console.Write(j + ": ");
                    var str = Console.ReadLine().Split(' ');
                    cm[j].c = Int32.Parse(str[0]);
                    cm[j].m = Int32.Parse(str[1]);
                }

                int[,] Tb = new int[M + 1, N + 1];
                for (int i = 1; i <= N; i++)

                    for (int x = 1; x <= M; x++)
                    {
                        if (x >= cm[i].m)
                            Tb[x, i] = Math.Max(Tb[x - cm[i].m, i - 1] + cm[i].c, Tb[x, i - 1]);
                    }
                Console.WriteLine("Максимальная стоимость груза: " + Tb[M, N]);
            }
            catch (Exception e) { Console.WriteLine("Ошибка " + e); }

            Console.ReadKey();
        }

        
        
    }
}
