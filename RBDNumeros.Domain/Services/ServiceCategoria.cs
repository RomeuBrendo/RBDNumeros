using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace RBDNumeros.Domain.Services
{
    public class ServiceCategoria : Notifiable, IServiceCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;

        public ServiceCategoria(IRepositoryCategoria repositoryCategoria)
        {
            _repositoryCategoria = repositoryCategoria;
        }

        public List<Categoria> ListarCategoria(string categoria)
        {
            if(categoria == "")
              return _repositoryCategoria.Listar().OrderBy(a => a.Nome).ToList();
            else
                return _repositoryCategoria.ListarFiltro(categoria).OrderBy(a => a.Nome).ToList();
        }

    }
}
