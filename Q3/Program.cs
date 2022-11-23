namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("123456", "Gabriel");
            Aluno a2 = new Aluno("654321", "Rafael");
            Aluno a3 = new Aluno("456123", "Diego");

            Curso c1 = new Curso("CC");
            Turma t1 = new Turma(1);
            Turma t2 = new Turma(2);

            t1.InserirAluno(a1);
            t1.InserirAluno(a2);

            c1.Matricular(a1);
            c1.Matricular(a2);
            c1.Matricular(a3);

            c1.CriarTurma(t1);
            c1.CriarTurma(t2);

            c1.Remover(a3);
            c1.RemoverTurma(t2);

            t1.ListarAlunos();
            c1.ListarTurmas();
        }
    }
}
