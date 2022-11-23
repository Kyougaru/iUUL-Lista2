namespace Q4
{
    public class Pessoa
    {
        private string nome;
        private CertidaoNascimento certidao;

        public string Nome
        {
            get { return nome; }
            private set { nome = value; }
        }

        public CertidaoNascimento Certidao
        {
            get { return certidao; }
            set {
                if(value._Pessoa.Equals(this))
                    certidao = value;
            }
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
