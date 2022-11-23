namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("123456", "Gabriel");
            Aluno a2 = new Aluno("654321", "Rafael");
            Aluno a3 = new Aluno("456123", "Diego");

            double[] a1Notas = { 7, 8 };
            double[] a2Notas = { 5, 6 };
            double[] a3Notas = { 9, 10 };

            a1.InserirNota(a1Notas);
            a2.InserirNota(a2Notas);
            a3.InserirNota(a3Notas);

            Aluno[] alunos = { a1, a2 };

            Turma t1 = new Turma(alunos);
            t1.InserirAluno(a3);
            t1.RemoverAluno(a2);

            t1.ListarAlunos();
            t1.ListarEstatisticas();
        }
    }
}
