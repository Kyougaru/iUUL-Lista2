using System;

namespace Q5
{
    public class Carro
    {
        private string placa;
        private string modelo;
        private Motor motor;

        public string Placa
        {
            get { return placa; }
            private set { placa = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            private set { modelo = value; }
        }

        public Motor _Motor
        {
            get { return motor; }
            set {
                if(value._Carro is not null)
                    throw new Exception("Não é possível colocar o mesmo motor em dois carros distintos");
                motor = value;
                motor._Carro = this;
            }
        }

        public Carro(string placa, string modelo, Motor motor)
        {
            Placa = placa;
            Modelo = modelo;
            _Motor = motor;
        }

        public double CalcVelocidade()
        {
            double vmax = 0;
            switch (_Motor.Cilindrada)
            {
                case double i when i > 0 && i <= 1.0:
                    vmax = 140;
                    break;
                case double i when i > 1.0 && i <= 1.6:
                    vmax = 160;
                    break;
                case double i when i > 1.6 && i <= 2.0:
                    vmax = 180;
                    break;
                case double i when i > 2.0:
                    vmax = 220;
                    break;
            }
            return vmax;
        }
    }
}
