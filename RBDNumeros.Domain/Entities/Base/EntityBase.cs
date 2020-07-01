using prmToolkit.NotificationPattern;
using System;

namespace RBDNumeros.Domain.Entities.Base
{
    public class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
