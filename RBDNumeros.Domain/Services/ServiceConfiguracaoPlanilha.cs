using prmToolkit.NotificationPattern;
using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;

namespace RBDNumeros.Domain.Services
{
    public class ServiceConfiguracaoPlanilha : Notifiable, IServiceConfiguracaoPlanilha
    {
        private readonly IRepositoryConfiguracaoPlanilha _repositoryConfiguracaoPlanilha;

        public ServiceConfiguracaoPlanilha(IRepositoryConfiguracaoPlanilha repositoryConfiguracaoPlanilha)
        {
            _repositoryConfiguracaoPlanilha = repositoryConfiguracaoPlanilha;
        }

        public void Adicionar(AdicionarConfiguracaoPlanilhaRequest r)
        {
            var conf = new ConfiguracaoPlanilha(r.NumeroTicket, r.ClienteNome, r.Categoria, r.DataAberturaTicket, r.DataResolvido, r.Tecnico, r.Carteira);

            AddNotifications(conf);

            if (IsInvalid()) return;

            _repositoryConfiguracaoPlanilha.Adicionar(conf);
        }
    }
}
