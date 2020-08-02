namespace RBDNumeros.Domain.Entities.KPI
{
    public class ChamadosPorCarteira
    {
        public ChamadosPorCarteira(int a, int b, int c, int d, int outros)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            Outros = outros;
        }

        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }
        public int D { get; private set; }
        public int Outros { get; private set; }
    }
}
