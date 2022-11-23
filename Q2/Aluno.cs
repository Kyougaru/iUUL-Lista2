namespace Q2
{
    public class Aluno
    {
        private string matricula;
        private string nome;
        private double[] notas = new double[2];

        public string Matricula 
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public void InserirNota(double[] notas)
        {
            Notas = notas;
        }

        public override bool Equals(object obj)
        {
            return obj is Aluno a &&
                   Matricula.Equals(a.Matricula);
        }
    }
}
