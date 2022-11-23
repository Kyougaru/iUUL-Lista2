namespace Q6
{
    public abstract class Progressao
    {
        private int primeiro;
        private int razao;
        private int proximoValor;

        public int Primeiro
        {
            get { return primeiro; }
            set { primeiro = value; }
        }

        public int Razao
        {
            get { return razao; }
            set { razao = value; }
        }

        public int ProximoValor
        {
            get { return proximoValor; }
            protected set { proximoValor = value; }
        }

        protected Progressao(int primeiro, int razao)
        {
            Primeiro = primeiro;
            Razao = razao;
        }

        public void Reinicializar()
        {
            ProximoValor = Primeiro;
        }

        public abstract int TermoAt(int posicao);
    }
}
