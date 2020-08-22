using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Enum;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBDNumeros.Domain.Services
{
    public class ServiceKPI : Notifiable, IServiceKPI
    {
        private readonly IRepositoryTicket _repositoryTicket;
        private readonly IRepositorySla _repositorySla;

        public ServiceKPI(IRepositoryTicket repositoryTicket, IRepositorySla repositorySla)
        {
            _repositoryTicket = repositoryTicket;
            _repositorySla = repositorySla;
        }

        public ChamadosPorCarteiraRequest ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim)
        {
            var chamados = new ChamadosPorCarteiraRequest();

            chamados.A = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date && 
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.A &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            chamados.B = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.B &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            chamados.C = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.C &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            chamados.D = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.D &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            return chamados;
        }

        public List<ChamadosPorSlaRequest> ChamadosPorSla(DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                var sla = _repositorySla.Listar().FirstOrDefault();
                var chamadosTotal = new ChamadosPorSlaRequest();

                List<ChamadosPorSlaRequest> chamadosLista = new List<ChamadosPorSlaRequest>();

                for (int i = 0; i < 4; i++)
                {
                    var chamados = new ChamadosPorSlaRequest();

                    EnumCarteira enumCarteira = (EnumCarteira)i;
                    chamados.Carteira = enumCarteira.ToString();
                    chamados.DentroSla = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                            a.DataAberturaTicket.Date <= dataFim.Date &&
                                                            a.Carteira == (EnumCarteira)i &&
                                                            a.Tecnico.ContabilizarNumeros &&
                                                            a.Categoria.ContabilizarNumeros &&
                                                            a.TempoVida <= sla.Dentro).Count();

                    chamados.Acima20 = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                            a.DataAberturaTicket.Date <= dataFim.Date &&
                                                            a.Carteira == (EnumCarteira)i &&
                                                            a.Tecnico.ContabilizarNumeros &&
                                                            a.Categoria.ContabilizarNumeros &&
                                                            a.TempoVida > sla.Dentro && a.TempoVida < sla.Estourado).Count();

                    chamados.Estourado = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                            a.DataAberturaTicket.Date <= dataFim.Date &&
                                                            a.Carteira == (EnumCarteira)i &&
                                                            a.Tecnico.ContabilizarNumeros &&
                                                            a.Categoria.ContabilizarNumeros &&
                                                            a.TempoVida >= sla.Estourado).Count();

                    chamadosTotal.DentroSla += chamados.DentroSla;
                    chamadosTotal.Acima20 += chamados.Acima20;
                    chamadosTotal.Estourado += chamados.Estourado;

                    chamadosLista.Add(chamados);
                }

                chamadosTotal.Carteira = "Total";
                chamadosLista.Add(chamadosTotal);

                return chamadosLista;

            }
            catch (Exception)
            {

                AddNotification("Banco","Erro ao carregar informações do banco de dados") ;
                return null;
            }

        }

        public List<Top10Response> Top10(Top10Request request)
        {
            if (request == null)
            {
                AddNotification("Request", "Não pode ser Nulo");
                return null;
            }

            var teste = _repositoryTicket.Top10(request);

            //var reponseList = new List<Top10Response>();
            //for (int i = 0; i < 4; i++)
            //{
            //    var chamados = _repositoryTicket.Listar(x => x.DataAberturaTicket.Date >= request.DataInicio.Date &&
            //                      x.DataAberturaTicket.Date <= request.DataFim.Date &&
            //                      x.Carteira == (EnumCarteira)i)
            //                      .Include(x => x.Cliente)
            //                      .GroupBy(x => x.Cliente.Nome).ToList();



            //}
            return null;                  
        }
    }
}
