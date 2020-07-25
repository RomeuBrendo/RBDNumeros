using Microsoft.EntityFrameworkCore;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;
using System.Linq;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryConfiguracaoPlanilha : RepositoryBase<ConfiguracaoPlanilha, Guid>, IRepositoryConfiguracaoPlanilha
    {
        private readonly RBDNumerosContext _context;
        public RepositoryConfiguracaoPlanilha(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }

        public ConfiguracaoPlanilha BuscarFirst()
        {
            try
            {
                return _context.ConfiguracaoPlanilhas.First();

            }
            catch 
            {

                return null;
            }
            
        }

        public void AdicionarAtualizar(ConfiguracaoPlanilha configuracaoPlanilha)
        {
            try
            {
                _context.ConfiguracaoPlanilhas.Add(configuracaoPlanilha);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
