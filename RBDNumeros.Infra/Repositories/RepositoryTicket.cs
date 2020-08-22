using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Enum;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryTicket : RepositoryBase<Ticket, Guid>, IRepositoryTicket
    {
        private readonly RBDNumerosContext _context;
        public RepositoryTicket(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }

        public List<Top10Response> Top10(Top10Request request)
        {
            try
            {
                var responseList = new List<Top10Response>();


                request.Carteira = EnumCarteira.Outros;


                var chamados = _context.Tickets.Where(x => x.DataAberturaTicket.Date >= request.DataInicio.Date &&
                                                        x.DataAberturaTicket.Date <= request.DataFim.Date &&
                                                        (request.Carteira == EnumCarteira.Outros) ? true : x.Carteira.Equals(request.Carteira) &&
                                                        x.Tecnico.ContabilizarNumeros == true &&
                                                        x.Categoria.ContabilizarNumeros == true)
                                                        .Include(x => x.Cliente).ToList()
                                                        .GroupBy(x => x.Cliente.Nome)
                                                        .Select(x => new { T = x.Count(), x.Key }).OrderByDescending(x => x.T);

                foreach (var item in chamados)
                {
                    var response = new Top10Response();
                    response.Carteira = request.Carteira;
                    response.ClienteNome = item.Key;
                    response.Quantidade = item.T;
                    responseList.Add(response);
                }

                return responseList;
            }
            catch (Exception)
            {
                return null;
            }

        }

    }


}
