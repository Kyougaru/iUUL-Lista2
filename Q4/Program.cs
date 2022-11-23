using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Gabriel");
            CertidaoNascimento c = new CertidaoNascimento(new DateTime(2001, 10, 18, 0, 0, 0), p);
            Console.WriteLine(c.DataEmissao);
            p.Certidao = c;
            Console.WriteLine(p.Certidao.DataEmissao);
        }
    }
}
