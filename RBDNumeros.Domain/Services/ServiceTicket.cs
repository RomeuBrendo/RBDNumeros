using iText.IO.Util;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Enum;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;

namespace RBDNumeros.Domain.Services
{
    public class ServiceTicket : Notifiable, IServiceTicket
    {
        private readonly IRepositoryTicket _repositoryTicket;
        private readonly IRepositoryCategoria _repositoryCategoria;
        private readonly IRepositoryCliente _repositoryCliente; 
        private readonly IRepositoryTecnico _repositoryTecnico; 
        public int ImportarTickets(List<ImportarTicketRequest> request)
        {
            if ((request == null) || (request.Count == 0))
            {
                AddNotification("Resquest", "Invalido");
                return 0;
            }

            List<Ticket> listaTicket = new List<Ticket>();

            foreach (var ticket in request)
            {
                if (!Int64.TryParse(ticket.NumeroTicket, out var numeroTicket))
                    continue;

                var cliente = VerificaCliente(ticket.ClienteNome, ticket.Carteira);
                var tecnico = VerificaTecnico(ticket.Tecnico, ticket.Carteira);
                var categoria = VerificaCategoria(ticket.Categoria);

                var dataAbertura = ConvertDataTime(ticket.DataAberturaTicket).Value;
                var dataResolvido = ConvertDataTime(ticket.DataResolvido).Value;

                if (dataAbertura == null)
                    continue;

                var ticketNovo = new Ticket(numeroTicket, cliente, categoria, dataAbertura, dataResolvido, tecnico);

                AddNotifications(ticketNovo);

                if (IsInvalid())
                    continue;

                listaTicket.Add(ticketNovo);
            }

            int ticketsImportados = listaTicket.Count;

            if (ticketsImportados > 0)
            {
                _repositoryTicket.AdicionarLista(listaTicket);

                if (ticketsImportados < request.Count)
                    AddNotification("TICKET", "Alguns tickets não foram importados, verifique a planilha.");

                return ticketsImportados;
            }
            else
                return 0;
        }

        private Categoria VerificaCategoria(string nome)
        {
            var categoria = _repositoryCategoria.ObterPor(x => x.Nome == nome);

            if (categoria == null)
            {
                var novaCategoria = new Categoria(nome);
                return _repositoryCategoria.Adicionar(novaCategoria);
            }
            return categoria;
        }

        private Tecnico VerificaTecnico(string nome, int carteira)
        {
            var tecnico = _repositoryTecnico.ObterPor(x => x.Nome == nome && x.Carteira == (EnumCarteira)carteira);

            if (tecnico == null)
            {
                var novoTecnico = new Tecnico(nome, (EnumCarteira)carteira, true);
                return _repositoryTecnico.Adicionar(novoTecnico);
            }

            return tecnico;
        }

        private Cliente VerificaCliente(string clienteNome, int carteira)
        {

            var cliente = _repositoryCliente.ObterPor(x => x.Nome == clienteNome && x.Carteira == (EnumCarteira)carteira);

            if (cliente == null)
            {
                var novoCliente = new Cliente(clienteNome, (EnumCarteira)carteira);
                return _repositoryCliente.Adicionar(novoCliente);
            }
            return cliente;
        }

        public DateTime? ConvertDataTime(string data)
        {

            if (!DateTime.TryParse(data, new CultureInfo("pt-BR"), DateTimeStyles.None, out var dataNova))
                return null;

            return dataNova;
        }
    }
}
