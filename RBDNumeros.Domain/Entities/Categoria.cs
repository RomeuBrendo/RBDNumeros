using RBDNumeros.Domain.Entities.Base;

namespace RBDNumeros.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public Categoria(string nome, bool contabilizarNumeros)
        {
            Nome = nome;
            ContabilizarNumeros = contabilizarNumeros;
        }

        protected Categoria()
        {

        }

        public string Nome { get; private set; }
        public bool ContabilizarNumeros { get; set; }
    }

}
