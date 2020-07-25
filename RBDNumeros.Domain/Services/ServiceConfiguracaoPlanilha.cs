using Org.BouncyCastle.Math.EC.Rfc7748;
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

        public bool Adicionar(AdicionarConfiguracaoPlanilhaRequest r)
        {
            try
            {
                var confSalvo = _repositoryConfiguracaoPlanilha.BuscarFirst();

                if (confSalvo != null)
                    _repositoryConfiguracaoPlanilha.Remover(confSalvo);

                var conf = new ConfiguracaoPlanilha(r.NumeroTicket, r.ClienteNome, r.Categoria, r.DataAberturaTicket, r.DataResolvido, r.Tecnico, r.Carteira);

                _repositoryConfiguracaoPlanilha.Adicionar(conf);

                return true;
            }
            catch
            {

                return false; ;
            }


        }

        public ConfiguracaoPlanilha CarregarConfiguracao()
        {
            return _repositoryConfiguracaoPlanilha.BuscarFirst();
        }
    }
}
