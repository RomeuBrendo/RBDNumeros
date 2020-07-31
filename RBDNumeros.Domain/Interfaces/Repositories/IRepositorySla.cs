using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories.Base;
using System;

namespace RBDNumeros.Domain.Interfaces.Repositories
{
    public interface IRepositorySla : IRepositoryBase<Sla, Guid>
    {
    }
}
