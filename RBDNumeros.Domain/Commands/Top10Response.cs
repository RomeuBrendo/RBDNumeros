using RBDNumeros.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Domain.Commands
{
    public class Top10Response
    {
        public string ClienteNome { get; set; }
        public Int64 Quantidade { get; set; }
        public String Carteira { get; set; }
    }
}
