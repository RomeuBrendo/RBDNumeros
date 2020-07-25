using Microsoft.Extensions.Configuration;
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
            
            //new AddNotifications<ConfiguracaoPlanilha>(this)
            //    .IfNullOrEmpty(x => x.NumeroTicket.ToString())
            //    .IfNullOrEmpty(x => x.ClienteNome.ToString())
            //    .IfNullOrEmpty(x => x.Carteira.ToString())
            //    .IfNullOrEmpty(x => x.Categoria.ToString())
            //    .IfNullOrEmpty(x => x.DataAberturaTicket.ToString())
            //    .IfNullOrEmpty(x => x.DataResolvido.ToString())
            //    .IfNullOrEmpty(x => x.Tecnico.ToString());
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
    }
}
