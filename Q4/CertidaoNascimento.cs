using System;

namespace Q4
{
    public class CertidaoNascimento
    {
        private DateTime dataEmissao;
        private Pessoa pessoa;

        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            private set { dataEmissao = value; }
        }

        public Pessoa _Pessoa
        {
            get { return pessoa; }
            private set { pessoa = value; }
        }

        public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa) 
        {
            DataEmissao = dataEmissao;
            _Pessoa = pessoa;
        }
    }
}
