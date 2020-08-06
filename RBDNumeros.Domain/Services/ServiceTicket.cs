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
using System.Linq;
using System.Threading;

namespace RBDNumeros.Domain.Services
{
    public class ServiceTicket : Notifiable, IServiceTicket
    {
        private readonly IRepositoryTicket _repositoryTicket;
        private readonly IRepositoryCategoria _repositoryCategoria;
        private readonly IRepositoryCliente _repositoryCliente; 
        private readonly IRepositoryTecnico _repositoryTecnico;
        private readonly IRepositoryConfiguracaoPlanilha _repositoryConfiguracaoPlanilha;
        public int porcentagem;
        public string proceso;
        public bool _cancelarImportacao = false;

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

            _cancelarImportacao = false;
            this.proceso = "Salvando no Banco de dados, Aguarde...";
            this.porcentagem = 0;

            //Trecho abaixo para otimizar tempo de importação, jogo todos na melhoria e vou consultando.
            var clientes = _repositoryCliente.Listar().ToList();
            var tecnicos = _repositoryTecnico.Listar().ToList();
            var categorias = _repositoryCategoria.Listar().ToList();

            List<Ticket> listaTicket = new List<Ticket>();
            List<Cliente> clienteNovos = new List<Cliente>();
            List<Tecnico> tecnicoNovos = new List<Tecnico>();
            List<Categoria> categoriaNovas = new List<Categoria>();

            var quantidade = request.Count();

            foreach (var ticket in request)
            {
                if (_cancelarImportacao)
                    return 0;

                this.porcentagem = (listaTicket.Count * 90) / quantidade;
                if (!Int64.TryParse(ticket.NumeroTicket, out var numeroTicket))
                    continue;

                var cliente = clientes.FirstOrDefault(x => x.Nome == ticket.ClienteNome && x.Carteira == (EnumCarteira)ticket.Carteira);

                if (cliente == null)
                {
                    cliente = new Cliente(ticket.ClienteNome, (EnumCarteira)ticket.Carteira);
                    clienteNovos.Add(cliente);
                }

                var tecnico = tecnicos.FirstOrDefault(x => x.Nome == ticket.Tecnico);

                if (tecnico == null)
                {
                    tecnico = new Tecnico(ticket.Tecnico, true, (EnumCarteira)ticket.Carteira);
                    tecnicoNovos.Add(tecnico);
                }

                var categoria = categorias.FirstOrDefault(x => x.Nome == ticket.Categoria);

                if (categoria == null)
                {
                    categoria = new Categoria(ticket.Categoria, true);
                    categoriaNovas.Add(categoria);
                }

                var dataAbertura = ConvertDataTime(ticket.DataAberturaTicket).Value;
                var dataResolvido = ConvertDataTime(ticket.DataResolvido);

                if (dataAbertura == null)
                    continue;

                var tempoVida = TimeSpan.Parse(ticket.TempoVida);

                var ticketNovo = new Ticket(numeroTicket, cliente, categoria, dataAbertura, dataResolvido, tecnico, tempoVida);

                AddNotifications(ticketNovo);

                if (IsInvalid())
                    continue;

                listaTicket.Add(ticketNovo);
                clientes.Add(cliente);
                tecnicos.Add(tecnico);
                categorias.Add(categoria);
            }

            int ticketsImportados = listaTicket.Count;

            if (ticketsImportados > 0)
            {
                if (clienteNovos.Count > 0)
                    _repositoryCliente.AdicionarLista(clienteNovos);

                if (tecnicoNovos.Count > 0)
                    _repositoryTecnico.AdicionarLista(tecnicoNovos);

                if (categoriaNovas.Count > 0)
                    _repositoryCategoria.AdicionarLista(categoriaNovas);

                _repositoryTicket.AdicionarLista(listaTicket);


                if (ticketsImportados < request.Count)
                    AddNotification("TICKET", "Alguns tickets não foram importados, verifique a planilha.");

                porcentagem = 90;
                return ticketsImportados;
            }
            else
                return 0;
        }

        public DateTime? ConvertDataTime(string data)
        {

            if (!DateTime.TryParse(data, new CultureInfo("pt-BR"), DateTimeStyles.None, out var dataNova))
                return null;

            return dataNova;
        }
        
        public int ImportarCsv(string caminho)
        {
            _cancelarImportacao = false;
            try
            {

                var wb = new XLWorkbook(@caminho);
                var planilha = wb.Worksheet(1);
                var linha = 2;
                var conf = _repositoryConfiguracaoPlanilha.BuscarFirst();

                this.proceso = "Lendo CSV, Aguarde...";
                var ListaTicket = new List<ImportarTicketRequest>();

                var quantidade = planilha.Rows().Count();

                while (true)
                {
                    if (_cancelarImportacao)
                        return 0;

                    this.porcentagem = (linha * 90) / quantidade;

                    var ticket = new ImportarTicketRequest();

                    ticket.NumeroTicket = planilha.Cell(conf.NumeroTicket + linha.ToString()).Value.ToString().Trim();

                    if (string.IsNullOrEmpty(ticket.NumeroTicket)) break;

                    ticket.ClienteNome = planilha.Cell(conf.ClienteNome + linha.ToString()).Value.ToString().Trim();
                    ticket.Categoria = planilha.Cell(conf.Categoria + linha.ToString()).Value.ToString().Trim();
                    ticket.DataAberturaTicket = planilha.Cell(conf.DataAberturaTicket + linha.ToString()).Value.ToString().Trim();
                    ticket.DataResolvido = planilha.Cell(conf.DataResolvido + linha.ToString()).Value.ToString().Trim();

                    ticket.TempoVida = planilha.Cell(conf.TempoVida + linha.ToString()).Value.ToString();
                    ticket.TempoVida = DateTime.Parse(ticket.TempoVida).ToLongTimeString();

                    ticket.Tecnico = planilha.Cell(conf.Tecnico + linha.ToString()).Value.ToString().Trim();

                    
             
                    if (ticket.Tecnico.Contains("A_"))
                        ticket.Carteira = 0;
                    else if (ticket.Tecnico.Contains("B_"))
                        ticket.Carteira = 1;
                    else if (ticket.Tecnico.Contains("C_"))
                        ticket.Carteira = 2;
                    else if (ticket.Tecnico.Contains("D_"))
                        ticket.Carteira = 3;
                    else
                        ticket.Carteira = 4;

                    ListaTicket.Add(ticket);
                    linha++;
                }

                

                return ImportarTickets(ListaTicket);

            }
            catch (Exception ex)
            {
                AddNotification("Planilha", "Verifique se a mesma não se encontra aberta.");
                return 0;
            }


        }

        public int RetornaPorcentagem()
        {
            return porcentagem;
        }

        public string RetornaProcesso()
        {
            return proceso;
        }

        public void CancelarImportacao()
        {
            _cancelarImportacao = true;
        }

        public int RetorneNumerosCarteira(int Carteira)
        {
            switch (Carteira)
            {
                case 0: return 5;
                    
                case 1: return 7;
                
                case 2:
                    return 23;
                  
                case 3:
                    return 4;
                 
                case 4:
                    return 1;
                
            }

            return 0;
        }

    }
}
