using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryConfiguracaoPlanilha : RepositoryBase<ConfiguracaoPlanilha, Guid>, IRepositoryConfiguracaoPlanilha
    {
        private readonly RBDNumerosContext _context;
        public RepositoryConfiguracaoPlanilha(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }
    }
}
