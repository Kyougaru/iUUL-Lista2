using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Propriedades p = new Propriedades("propriedades.txt");
            Console.WriteLine(p.PegarValorDeChave("url"));
            Console.WriteLine(p.ChaveExiste("email"));
            p.AlterarValorDeChave("porta", "5050");
            Console.WriteLine(p.PegarValorDeChave("porta"));
            p.SalvarPropriedades();
        }
    }
}
