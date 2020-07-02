using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceTicket : IServiceBase
    {
        int ImportarTickets(List<ImportarTicketRequest> request);
    }
}
