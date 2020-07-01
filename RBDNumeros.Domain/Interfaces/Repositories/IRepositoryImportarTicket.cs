using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Repositories
{
    public interface IRepositoryImportarTicket : IRepositoryBase<List<Ticket>, Guid>
    {
    }
}
