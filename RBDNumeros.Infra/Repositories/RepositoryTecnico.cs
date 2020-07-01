using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryTecnico : RepositoryBase<Tecnico, Guid>, IRepositoryTecnico
    {
        private readonly RBDNumerosContext _context;
        public RepositoryTecnico(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }
    }
}
