using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryRede : RepositoryBase<Rede, Guid>, IRepositoryRede
    {
        private readonly RBDNumerosContext _context;
        public RepositoryRede(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }
    }
}
