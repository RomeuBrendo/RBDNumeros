using ClosedXML.Excel;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Enum;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RBDNumeros.Domain.Services
{
    public class ServiceTicket : Notifiable, IServiceTicket
    {
        private readonly IRepositoryTicket _repositoryTicket;
        private readonly IRepositoryCategoria _repositoryCategoria;
        private readonly IRepositoryCliente _repositoryCliente; 
        private readonly IRepositoryTecnico _repositoryTecnico;
        private readonly IRepositoryConfiguracaoPlanilha _repositoryConfiguracaoPlanilha;

        public ServiceTicket(IRepositoryTicket repositoryTicket, IRepositoryCategoria repositoryCategoria, IRepositoryCliente repositoryCliente, IRepositoryTecnico repositoryTecnico, IRepositoryConfiguracaoPlanilha repositoryConfiguracaoPlanilha)
        {
            _repositoryTicket = repositoryTicket;
            _repositoryCategoria = repositoryCategoria;
            _repositoryCliente = repositoryCliente;
            _repositoryTecnico = repositoryTecnico;
            _repositoryConfiguracaoPlanilha = repositoryConfiguracaoPlanilha;
        }

        private int ImportarTickets(List<ImportarTicketRequest> request)
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
                var dataResolvido = ConvertDataTime(ticket.DataResolvido);

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
                return _repositoryCategoria.AdicionarCommitar(novaCategoria);
            }
            return categoria;
        }

        private Tecnico VerificaTecnico(string nome, int carteira)
        {
            var tecnico = _repositoryTecnico.ObterPor(x => x.Nome == nome && x.Carteira == (EnumCarteira)carteira);

            if (tecnico == null)
            {
                var novoTecnico = new Tecnico(nome, (EnumCarteira)carteira, true);
                return _repositoryTecnico.AdicionarCommitar(novoTecnico);
            }

            return tecnico;
        }

        private Cliente VerificaCliente(string clienteNome, int carteira)
        {

            var cliente = _repositoryCliente.ObterPor(x => x.Nome == clienteNome && x.Carteira == (EnumCarteira)carteira);

            if (cliente == null)
            {
                var novoCliente = new Cliente(clienteNome, (EnumCarteira)carteira);
                return _repositoryCliente.AdicionarCommitar(novoCliente);
            }
            return cliente;
        }

        public DateTime? ConvertDataTime(string data)
        {

            if (!DateTime.TryParse(data, new CultureInfo("pt-BR"), DateTimeStyles.None, out var dataNova))
                return null;

            return dataNova;
        }
        
        public int ImportarCsv(string caminho)
        {
            var wb = new XLWorkbook(@caminho);
            var planilha = wb.Worksheet(1);
            var linha = 2;

            var conf = _repositoryConfiguracaoPlanilha.BuscarFirst();

            var ListaTicket = new List<ImportarTicketRequest>();

            while (true)
            {
                var ticket = new ImportarTicketRequest();

                ticket.NumeroTicket = planilha.Cell(conf.NumeroTicket + linha.ToString()).Value.ToString().Trim();

                if (string.IsNullOrEmpty(ticket.NumeroTicket)) break;

                ticket.ClienteNome = planilha.Cell(conf.ClienteNome + linha.ToString()).Value.ToString().Trim();
                ticket.Categoria = planilha.Cell(conf.Categoria + linha.ToString()).Value.ToString().Trim();
                ticket.DataAberturaTicket = planilha.Cell(conf.DataAberturaTicket + linha.ToString()).Value.ToString().Trim();
                ticket.DataResolvido = planilha.Cell(conf.DataResolvido + linha.ToString()).Value.ToString().Trim();
                ticket.Tecnico = planilha.Cell(conf.Tecnico + linha.ToString()).Value.ToString().Trim();

                switch ((planilha.Cell(conf.Carteira + linha.ToString()).Value.ToString().Trim()))
                {
                    case "Carteira A":
                        ticket.Carteira = 0;
                        break;            
                   
                    case "Carteira B":
                        ticket.Carteira = 1;
                        break;
                    
                    case "Carteira C":
                        ticket.Carteira = 2;
                        break;
                    
                    case "Carteira D":
                        ticket.Carteira = 3;
                        break;

                    case "Nível II":
                        ticket.Carteira = 4;
                        break;

                    default:
                        ticket.Carteira = 5;
                        break;

                }

                ListaTicket.Add(ticket);
                linha++;
            }


            return ImportarTickets(ListaTicket);
        }

    }
}
