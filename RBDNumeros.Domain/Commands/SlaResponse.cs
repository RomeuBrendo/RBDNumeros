using RBDNumeros.Domain.Entities;
using System;

namespace RBDNumeros.Domain.Commands
{
    public class SlaResponse
    {
        protected SlaResponse()
        {
        }

        public SlaResponse(string dentro, string acima20, string estourado)
        {
            Dentro = dentro;
            Acima20 = acima20;
            Estourado = estourado;
        }

        public string Dentro { get; set; }
        public string Acima20 { get; set; }
        public string Estourado { get; set; }

        public static explicit operator SlaResponse(Sla v)
        {
            return new SlaResponse()
            {
                Dentro = Convert.ToString(v.Dentro),
                Acima20 = Convert.ToString(v.Acima20),
                Estourado = Convert.ToString(v.Estourado)
            };

                

        }
    }
}
