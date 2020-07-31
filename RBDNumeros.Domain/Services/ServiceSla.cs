using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System.Linq;

namespace RBDNumeros.Domain.Services
{
    public class ServiceSla : Notifiable, IServiceSla
    {
        private readonly IRepositorySla _repositorySla;

        public ServiceSla(IRepositorySla repositorySla)
        {
            _repositorySla = repositorySla;
        }

        public bool InserirAlterar(AdicionarAlterarSlaRequest request)
        {
            if(request == null)
            {
                AddNotification("Request", "Inválido");
                return false;
            }

            var sla = _repositorySla.Listar().FirstOrDefault();

            if (sla != null)
            {
                _repositorySla.Remover(sla);
            }

            sla = new Sla(request.Dentro, request.Acima20, request.Estourado);
            AddNotifications(sla);

            if (IsInvalid()) return false;

            _repositorySla.Adicionar(sla);

            return true;
        }

        public Sla ObterRegistro()
        {
            return _repositorySla.Listar().FirstOrDefault();
        }
    }
}
