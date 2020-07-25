using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Services.Base;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceConfiguracaoPlanilha : IServiceBase
    {
        bool Adicionar(AdicionarConfiguracaoPlanilhaRequest request);
        ConfiguracaoPlanilha CarregarConfiguracao();
    }
}
