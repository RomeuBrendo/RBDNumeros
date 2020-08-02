using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RBDNumeros.Infra.Repositories
{
    public class RepositoryCategoria : RepositoryBase<Categoria, Guid>, IRepositoryCategoria
    {
        private readonly RBDNumerosContext _context;
        public RepositoryCategoria(RBDNumerosContext context) : base(context)
        {
            _context = context;
        }

        public List<Categoria> ListarFiltro(string categoria)
        {
            return _context.Categorias.Where(x => x.Nome.StartsWith(categoria)).ToList();
        }
    }
}
