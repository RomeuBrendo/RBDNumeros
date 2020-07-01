using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.Base;

namespace RBDNumeros.Domain.Entities
{
    public class Rede : EntityBase
    {
        protected Rede()
        {

        }
        public Rede(string nome)
        {
            Nome = nome;

            new AddNotifications<Rede>(this)
                .IfNullOrEmpty(x => x.Nome);
        }

        public string Nome { get; private set; }
    }
}
