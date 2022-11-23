namespace Q3
{
    public class Aluno
    {
        private string nome;
        private string matricula;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno a &&
                   Matricula.Equals(a.Matricula);
        }
    }
}
