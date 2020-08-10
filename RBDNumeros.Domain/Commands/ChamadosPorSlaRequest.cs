namespace RBDNumeros.Domain.Commands
{
    public class ChamadosPorSlaRequest
    {
        public string Carteira { get; set; }
        public int DentroSla { get; set; }
        public int Acima20 { get; set; }
        public int Estourado { get; set; }
    }
}
