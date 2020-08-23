using RBDNumeros.Domain.Enum;
using System;

namespace RBDNumeros.Domain.Commands
{
    public class Top10Request
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public EnumCarteira Carteira { get; set; }
    }
}
