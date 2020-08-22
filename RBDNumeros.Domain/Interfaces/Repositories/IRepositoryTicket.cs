using DocumentFormat.OpenXml.Office2010.ExcelAc;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Repositories
{
    public interface IRepositoryTicket : IRepositoryBase<Ticket, Guid>
    {
        List<Top10Response> Top10(Top10Request request);
    }
}
