using System;

namespace RBDNumeros.Domain.Commands
{
    public class AdicionarAlterarSlaRequest
    {
        public TimeSpan Dentro { get; set; }
        public TimeSpan Acima20 { get; set; }
        public TimeSpan Estourado { get; set; }
    }
}
