using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities.Base;
using System;

namespace RBDNumeros.Domain.Entities
{
    public class ConfiguracaoPlanilha : EntityBase
    {
        public ConfiguracaoPlanilha(char numeroTicket, char clienteNome, char categoria, char dataAberturaTicket, char dataResolvido, char tecnico, char carteira)
        {
            NumeroTicket = numeroTicket;
            ClienteNome = clienteNome;
            Categoria = categoria;
            DataAberturaTicket = dataAberturaTicket;
            DataResolvido = dataResolvido;
            Tecnico = tecnico;
            Carteira = carteira;

            new AddNotifications<ConfiguracaoPlanilha>(this)
                .IfNull(x => x.NumeroTicket)
                .IfNull(x => x.ClienteNome)
                .IfNull(x => x.Carteira)
                .IfNull(x => x.Categoria)
                .IfNull(x => x.DataAberturaTicket)
                .IfNull(x => x.DataResolvido)
                .IfNull(x => x.Tecnico);
        }

        public char NumeroTicket { get; private set; }
        public char ClienteNome { get; private set; }
        public char Categoria { get; private set; }
        public char DataAberturaTicket { get; private set; }
        public char DataResolvido { get; private set; }
        public char Tecnico { get; private set; }
        public char Carteira { get; private set; }
    }
}
