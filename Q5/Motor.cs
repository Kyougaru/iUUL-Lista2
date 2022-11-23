using System;

namespace Q5
{
    public class Motor
    {
        private double cilindrada;
        private Carro carro;

        public double Cilindrada
        {
            get { return cilindrada; }
            private set { cilindrada = value; }
        }

        public Carro _Carro
        {
            get { return carro; }
            set {
                if (value._Motor.Equals(this))
                    carro = value;
                else
                    throw new Exception("Não é possível colocar o mesmo motor em dois carros distintos");
            }
        }

        public Motor(double cilindrada)
        {
            Cilindrada = cilindrada;
        }
    }
}
