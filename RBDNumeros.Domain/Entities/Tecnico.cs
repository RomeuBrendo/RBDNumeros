using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.Base;
using RBDNumeros.Domain.Enum;

namespace RBDNumeros.Domain.Entities
{
    public class Tecnico : EntityBase
    {
        protected Tecnico()
        {

        }
        public Tecnico(bool contabilizarNumeros)
        {
            ContabilizarNumeros = contabilizarNumeros;
        }

        public Tecnico(string nome, EnumCarteira carteira, bool contabilizarNumeros)
        {
            Nome = nome;
            Carteira = carteira;
            ContabilizarNumeros = contabilizarNumeros;

            new AddNotifications<Tecnico>(this)
                .IfNullOrEmpty(x => x.Nome)
                .IfNull(x => x.Carteira);
        }

        public string Nome { get; private set; }
        public EnumCarteira Carteira { get; private set; }
        public bool ContabilizarNumeros { get; private set; }
    }
}
