using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories.Base;
using System;

namespace RBDNumeros.Domain.Interfaces.Repositories
{
    public interface IRepositoryConfiguracaoPlanilha : IRepositoryBase<ConfiguracaoPlanilha, Guid>
    {
        ConfiguracaoPlanilha BuscarFirst();
    }
}
