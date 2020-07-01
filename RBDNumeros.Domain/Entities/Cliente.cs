using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities.Base;
using RBDNumeros.Domain.Enum;
using System;

namespace RBDNumeros.Domain.Entities
{
    public class Cliente : EntityBase
    {
        protected Cliente()
        {

        }
        public Cliente(string nome, Rede rede, EnumCarteira carteira)
        {
            Nome = nome;
            Rede = rede;
            Carteira = carteira;

            new AddNotifications<Cliente>(this)
                .IfNullOrEmpty(x => x.Nome)
                .IfNull(x => x.Rede)
                .IfEnumInvalid(x => x.Carteira);
            
        }

        public string Nome { get; private set; }
        public Rede Rede { get; private set; }
        public EnumCarteira Carteira { get; private set; }
    }
}
