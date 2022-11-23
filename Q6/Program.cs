using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgressaoAritmetica pa = new ProgressaoAritmetica(3, 4);
            ProgressaoGeometrica pg = new ProgressaoGeometrica(3, 4);
            Console.WriteLine("10 primeiros termos da PA:");
            for (int i=1; i<=10; i++)
            {
                Console.Write(pa.TermoAt(i) + " ");
            }
            Console.WriteLine("\n10 primeiros termos da PG:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(pg.TermoAt(i) + " ");
            }
        }
    }
}
