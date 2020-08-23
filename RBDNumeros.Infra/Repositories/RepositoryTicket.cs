using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Org.BouncyCastle.Utilities;
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

                if (request.Carteira != EnumCarteira.Outros)
                {
                    var chamados = _context.Tickets.Where(x => x.DataAberturaTicket.Date >= request.DataInicio.Date &&
                                                                            x.DataAberturaTicket.Date <= request.DataFim.Date &&
                                                                            x.Carteira == request.Carteira &&
                                                                            x.Tecnico.ContabilizarNumeros == true &&
                                                                            x.Categoria.ContabilizarNumeros == true)
                                                                            .GroupBy(x => x.Cliente.Nome)
                                                                            .Select(x => new { T = x.Count(), x.Key }).OrderByDescending(x => x.T).ToList();

                    foreach (var item in chamados)
                    {
                        var response = new Top10Response();
                        response.Carteira = ReturnCarteiraByCod(request.Carteira);
                        response.ClienteNome = item.Key;
                        response.Quantidade = item.T;
                        responseList.Add(response);
                    }

                    return responseList;
                }

                else
                {
                    var chamados = _context.Tickets.Where(x => x.DataAberturaTicket.Date >= request.DataInicio.Date &&
                                                                                x.DataAberturaTicket.Date <= request.DataFim.Date &&
                                                                                x.Tecnico.ContabilizarNumeros == true &&
                                                                                x.Categoria.ContabilizarNumeros == true)
                                                                                .GroupBy(x => x.Cliente.Nome)
                                                                                .Select(x => new { T = x.Count(), x.Key}).OrderByDescending(x => x.T).ToList(); ;

                    foreach (var item in chamados)
                    {
                        var response = new Top10Response();
                        response.Carteira = "";
                        response.ClienteNome = item.Key;
                        response.Quantidade = item.T;
                        responseList.Add(response);
                    }

                    return responseList;

                }

            }
            catch (Exception)
            {
                return null;
            }

        }

        private String ReturnCarteiraByCod(EnumCarteira codCarteira)
        {
            String Carteira = "";

            if (codCarteira == EnumCarteira.A)
            {
                Carteira = "A";
            }
            else if (codCarteira == EnumCarteira.B)
            {
                Carteira = "B";
            }
            else if (codCarteira == EnumCarteira.C)
            {
                Carteira = "C";
            }
            else if (codCarteira == EnumCarteira.D)
            {
                Carteira = "D";
            }
            else if (codCarteira == EnumCarteira.Outros)
            {
                Carteira = "OUTROS";
            }
            else if (codCarteira == EnumCarteira.N2)
            {
                Carteira = "N2";
            }
            else
            {
                Carteira = "Não definido";
            }

            return Carteira;

        }

    }


}
