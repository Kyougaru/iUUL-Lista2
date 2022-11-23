using System;
using System.Collections.Generic;
using System.Linq;

namespace Q3
{
    public class Turma
    {
        private int codigo;
        private List<Aluno> alunos;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public Turma(int codigo)
        {
            Codigo = codigo;
            Alunos = new List<Aluno>();
        }

        public void InserirAluno(Aluno aluno)
        {
            if (EstaNaTurma(aluno))
            {
                throw new Exception("O aluno já está cadastrado na turma.");
            }
            else
            {
                Alunos.Add(aluno);
            }
        }

        public void RemoverAluno(Aluno aluno)
        {
            if (EstaNaTurma(aluno))
            {
                Alunos.Remove(aluno);
            }
            else
            {
                throw new Exception("O aluno não está na turma.");
            }
        }

        public bool EstaNaTurma(Aluno aluno)
        {
            foreach (Aluno a in Alunos)
            {
                if (a.Equals(aluno))
                {
                    return true;
                }
            }
            return false;
        }

        public void ListarAlunos()
        {
            List<Aluno> listaOrdenada = Alunos.OrderBy(x => x.Nome).ToList();
            foreach (Aluno a in listaOrdenada)
            {
                Console.WriteLine("Aluno: " + a.Nome + " Matricula: " + a.Matricula);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Turma t &&
                   Codigo.Equals(t.Codigo);
        }
    }
}
