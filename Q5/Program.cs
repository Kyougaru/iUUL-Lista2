using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor m1 = new Motor(1.6);
            Motor m2 = new Motor(2.0);

            Carro c1 = new Carro("RIO1B34", "Uno", m1);
            Carro c2 = new Carro("RIO2A56", "Palio", m2);

            /*Gera erro:
            Carro c3 = new Carro("RIO2A56", "Palio", m1);
            m1._Carro = c2;
            */

            Console.WriteLine(c1.CalcVelocidade());
            Console.WriteLine(c2.CalcVelocidade());
        }
    }
}
