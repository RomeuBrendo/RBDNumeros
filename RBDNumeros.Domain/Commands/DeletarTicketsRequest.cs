using System;

namespace RBDNumeros.Domain.Commands
{
    public class DeletarTicketsRequest
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
