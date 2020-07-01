using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente, Guid>, IRepositoryCliente
    {
        private readonly RBDNumerosContext _context;
        public RepositoryCliente(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }
    }
}
