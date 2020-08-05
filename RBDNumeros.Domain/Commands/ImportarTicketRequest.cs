namespace RBDNumeros.Domain.Commands
{
    public class ImportarTicketRequest
    {
        public string NumeroTicket { get; set; }
        public string ClienteNome { get; set; }
        public string Categoria { get; set; }
        public string DataAberturaTicket { get; set; }
        public string DataResolvido { get; set; }
        public string Tecnico { get; set; }
        public int Carteira { get; set; }
        public string TempoVida { get; set; }
    }
}

