using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Entities.KPI;
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

        public ChamadosPorCarteira ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim)
        {
            var A = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date && 
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.A &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            var B = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.B &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            var C = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.C &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            var D = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.D &&
                                                        a.Tecnico.ContabilizarNumeros &&
                                                        a.Categoria.ContabilizarNumeros).Count();


            return new ChamadosPorCarteira(A, B, C, D, 0);
        }

        public List<ChamadosPorSlaRequest> ChamadosPorSla(DateTime dataInicio, DateTime dataFim)
        {
            var sla = _repositorySla.Listar().FirstOrDefault();
            List<ChamadosPorSlaRequest> chamadosLista = new List<ChamadosPorSlaRequest>();

            for (int i = 0; i < 4; i++)
            {
                var chamados = new ChamadosPorSlaRequest();

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

                chamadosLista.Add(chamados);
            }

            return chamadosLista;
        }
    }
}
