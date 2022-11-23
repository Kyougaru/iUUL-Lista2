using System;
using System.Collections.Generic;
using System.Linq;

namespace Q3
{
    public class Curso
    {
        private string nome;
        private List<Aluno> alunos;
        private List<Turma> turmas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
            set { alunos = value; }
        }

        public List<Turma> Turmas
        {
            get { return turmas; }
            set { turmas = value; }
        }

        public Curso(string nome) {
            Nome = nome;
            Alunos = new List<Aluno>();
            Turmas = new List<Turma>();
        }

        public void Matricular(Aluno aluno)
        {
            if (MesmoAlunoId(aluno))
            {
                throw new Exception("O aluno já está cadastrado no curso.");
            }
            else
            {
                Alunos.Add(aluno);
            }
        }

        public void Remover(Aluno aluno)
        {
            foreach(Turma turma in Turmas)
            {
                if(turma.EstaNaTurma(aluno))
                    throw new Exception("O aluno está em uma turma.");
            }
            if (MesmoAlunoId(aluno))
            {
                Alunos.Remove(aluno);
            }
            else
            {
                throw new Exception("O aluno não está na turma.");
            }
        }

        public void CriarTurma(Turma turma)
        {
            if (MesmaTurmaId(turma))
            {
                throw new Exception("A turma já está cadastrada no curso.");
            }
            else
            {
                Turmas.Add(turma);
            }
        }

        public void RemoverTurma(Turma turma)
        {
            if (MesmaTurmaId(turma) && turma.Alunos.Count == 0)
            {
                Turmas.Remove(turma);
            }
            else
            {
                throw new Exception("A turma não está no curso.");
            }
        }

        public bool MesmaTurmaId(Turma turma)
        {
            foreach (Turma t in Turmas)
            {
                if (t.Equals(turma))
                {
                    return true;
                }
            }
            return false;
        }

        public bool MesmoAlunoId(Aluno aluno)
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

        public void ListarTurmas()
        {
            List<Turma> listaOrdenada = Turmas.OrderBy(x => x.Codigo).ThenBy(x => x.Alunos.OrderBy(x => x.Nome).ToList()).ToList();
            foreach (Turma t in listaOrdenada)
            {
                Console.WriteLine("Turma: " + t.Codigo + " :");
                foreach (Aluno a in t.Alunos)
                {
                    Console.WriteLine("Aluno: " + a.Nome + " Matricula: " + a.Matricula);
                }
            }
        }
    }
}
