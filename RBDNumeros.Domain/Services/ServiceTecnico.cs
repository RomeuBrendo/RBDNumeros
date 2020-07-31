using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace RBDNumeros.Domain.Services
{
    public class ServiceTecnico : Notifiable, IServiceTecnico
    {
        private readonly IRepositoryTecnico _repositoryTecnico;

        public ServiceTecnico(IRepositoryTecnico repositoryTecnico)
        {
            _repositoryTecnico = repositoryTecnico;
        }

        public List<Tecnico> ListarTecnico()
        {
            return _repositoryTecnico.Listar().OrderBy(x => x.Nome).ToList();
        }
    }
}
