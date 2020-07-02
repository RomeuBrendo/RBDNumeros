using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Domain.Commands
{
    public class AdicionarConfiguracaoPlanilhaRequest
    {
        public char NumeroTicket { get; set; }
        public char ClienteNome { get; set; }
        public char Categoria { get; set; }
        public char DataAberturaTicket { get; set; }
        public char DataResolvido { get; set; }
        public char Tecnico { get; set; }
        public char Carteira { get; set; }
    }
}
