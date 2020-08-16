using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryTicket : RepositoryBase<Ticket, Guid>, IRepositoryTicket
    {
        private readonly RBDNumerosContext _context;
        public RepositoryTicket(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }

    }
}
