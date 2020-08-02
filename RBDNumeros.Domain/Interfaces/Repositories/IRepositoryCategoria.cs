using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Repositories
{
    public interface IRepositoryCategoria : IRepositoryBase<Categoria, Guid>
    {
        List<Categoria> ListarFiltro(string categoria);
    }
}
