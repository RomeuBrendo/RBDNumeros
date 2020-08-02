using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.KPI;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace RBDNumeros.Domain.Services
{
    public class ServiceKPI : Notifiable, IServiceKPI
    {
        private readonly IRepositoryTicket _repositoryTicket;

        public ServiceKPI(IRepositoryTicket repositoryTicket)
        {
            _repositoryTicket = repositoryTicket;
        }

        public ChamadosPorCarteira ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim)
        {
            var A = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date && 
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.A &&
                                                        a.Tecnico.ContabilizarNumeros == true)
                                                        .Include(x => x.Tecnico).Include(x => x.Categoria).Count();

            var B = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.B)
                                                       .Include(x => x.Tecnico).Count();

            var C = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.C)
                                                        .Include(x => x.Tecnico).Count();

            var D = _repositoryTicket.ListarPor(a => a.DataAberturaTicket.Date >= dataInicio.Date &&
                                                        a.DataAberturaTicket.Date <= dataFim.Date &&
                                                        a.Carteira == Enum.EnumCarteira.D)
                                                        .Include(x => x.Tecnico).Count();

            return new ChamadosPorCarteira(A, B, C, D, 0);
        }
    }
}
