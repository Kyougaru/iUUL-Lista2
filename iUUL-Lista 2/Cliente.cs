using System;
using System.Globalization;

namespace iUUL_Lista_2
{
    public class Cliente
    {
        private string nome;
        private long cpf;
        private DateTime dataNasc;
        private float rendaMensal;
        private char estadoCivil;
        private int dependentes;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public float RendaMensal
        {
            get { return rendaMensal; }
            set { rendaMensal = value; }
        }

        public char EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        public int Dependentes
        {
            get { return dependentes; }
            set { dependentes = value; }
        }

        public Cliente(string nome, string cpf, string dataNasc, string rendaMensal, string estadoCivil, string dependentes)
        {
            Nome = nome;
            Cpf = long.Parse(cpf);
            DataNasc = DateTime.ParseExact(s: dataNasc, format: "dd/MM/yyyy", provider: new CultureInfo("pt-BR"));
            RendaMensal = float.Parse(rendaMensal, new CultureInfo("pt-BR"));
            EstadoCivil = char.Parse(estadoCivil);
            Dependentes = int.Parse(dependentes);
        }
    }
}
