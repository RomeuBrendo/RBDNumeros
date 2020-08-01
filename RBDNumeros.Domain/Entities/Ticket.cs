using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.Base;
using RBDNumeros.Domain.Enum;
using System;

namespace RBDNumeros.Domain.Entities
{
    public class Ticket : EntityBase
    {
        protected Ticket()
        {

        }
        public Ticket(long numeroTicket, Cliente cliente, Categoria categoria, DateTime dataAberturaTicket, DateTime? dataResolvido, Tecnico tecnico)
        {
            NumeroTicket = numeroTicket;
            Cliente = cliente;
            Categoria = categoria;
            DataAberturaTicket = dataAberturaTicket;
            DataResolvido = dataResolvido;
            Tecnico = tecnico;
            Carteira = tecnico.Carteira;

            if (NumeroTicket < 1)
                AddNotification("NumeroTicket", "Invalido");

            //new AddNotifications<Ticket>(this)
            //    .IfNull(x => x.Cliente)
            //    .IfNull(x => Categoria)
            //    .IfNotDate(x => x.DataAberturaTicket.ToString())
            //    .IfNotDate(x => x.DataResolvido.ToString())
            //    .IfNull(x => x.Tecnico);
        }

        public Int64 NumeroTicket { get; private set; }
        public Cliente Cliente { get; private set; }
        public Categoria Categoria { get; private set; }
        public DateTime DataAberturaTicket { get; private set; }
        public DateTime? DataResolvido { get; private set; }
        public Tecnico Tecnico { get; private set; }
        public EnumCarteira Carteira { get; private set; }
    }
}
