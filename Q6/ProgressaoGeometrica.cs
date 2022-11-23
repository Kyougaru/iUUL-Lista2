namespace Q6
{
    public class ProgressaoGeometrica : Progressao
    {
        public ProgressaoGeometrica(int primeiro, int razao) : base(primeiro, razao)
        {

        }

        public override int TermoAt(int posicao)
        {
            Reinicializar();
            if (posicao > 1)
            {
                for (int i = 2; i <= posicao; i++)
                {
                    ProximoValor *= Razao;
                }
            }
            return ProximoValor;
        }
    }
}
