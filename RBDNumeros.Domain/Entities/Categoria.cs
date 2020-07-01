using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.Base;

namespace RBDNumeros.Domain.Entities
{
    public class Categoria : EntityBase
    {
        protected Categoria()
        {

        }
        public Categoria(string nome)
        {
            Nome = nome;

            new AddNotifications<Categoria>(this)
                .IfNullOrEmpty(x => x.Nome);
        }

        public string Nome { get; private set; }
    }

}
