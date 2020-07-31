using Org.BouncyCastle.Asn1.Cms;
using RBDNumeros.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Domain.Entities
{
    public class Sla : EntityBase
    {
        public Sla(TimeSpan dentro, TimeSpan acima20, TimeSpan estourado)
        {
            Dentro = dentro;
            Acima20 = acima20;
            Estourado = estourado;
        }

        public TimeSpan Dentro { get; private set; }
        public TimeSpan Acima20 { get; private set; }
        public TimeSpan Estourado { get; private set; }
    }
}
