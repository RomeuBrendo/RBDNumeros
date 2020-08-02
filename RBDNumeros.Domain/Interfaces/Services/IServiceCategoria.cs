using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceCategoria : IServiceBase
    {
        List<Categoria> ListarCategoria(string categoria);
    }
}
