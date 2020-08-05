using RBDNumeros.Domain.Entities.Base;

namespace RBDNumeros.Domain.Entities
{
    public class ConfiguracaoPlanilha : EntityBase
    {
        public ConfiguracaoPlanilha(char numeroTicket, char clienteNome, char categoria, char dataAberturaTicket, char dataResolvido, char tecnico, char carteira, char tempoVida)
        {
            NumeroTicket = numeroTicket;
            ClienteNome = clienteNome;
            Categoria = categoria;
            DataAberturaTicket = dataAberturaTicket;
            DataResolvido = dataResolvido;
            Tecnico = tecnico;
            Carteira = carteira;
            TempoVida = tempoVida;
        }

        protected ConfiguracaoPlanilha()
        {
        }

        public char NumeroTicket { get; private set; }
        public char ClienteNome { get; private set; }
        public char Categoria { get; private set; }
        public char DataAberturaTicket { get; private set; }
        public char DataResolvido { get; private set; }
        public char Tecnico { get; private set; }
        public char Carteira { get; private set; }
        public char TempoVida { get; private set; }
    }
}
