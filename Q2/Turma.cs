using System;
using System.Collections.Generic;
using System.Linq;

namespace Q2
{
    public class Turma
    {
        private List<Aluno> alunos;

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public Turma(Aluno[] alunos)
        {
            Alunos = new List<Aluno>();

            foreach(Aluno aluno in alunos)
            {
                Alunos.Add(aluno);
            }
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

            foreach(Aluno a in listaOrdenada)
            {
                Console.WriteLine("Aluno: " + a.Nome + " NF: " + (a.Notas[0] + a.Notas[1]) / 2);
            }
        }

        public void ListarEstatisticas()
        {
            double p1 = 0, p2 = 0, nf = 0, maiorNf = 0;
            string matricula = "", nome = "";

            foreach (Aluno a in Alunos)
            {
                p1 += a.Notas[0];
                p2 += a.Notas[1];

                double mediaAluno = (a.Notas[0] + a.Notas[1]) / 2;
                nf += mediaAluno;

                if (mediaAluno > maiorNf)
                {
                    maiorNf = mediaAluno;
                    matricula = a.Matricula;
                    nome = a.Nome;
                }
            }
            Console.WriteLine("Média da P1: " + p1 / Alunos.Count);
            Console.WriteLine("Média da P2: " + p2 / Alunos.Count);
            Console.WriteLine("Média da Turma: " + nf / Alunos.Count);
            Console.WriteLine("Maior NF da Turma: " + maiorNf + " pelo aluno " + nome + " com matrícula " + matricula);
        }
    }
}
