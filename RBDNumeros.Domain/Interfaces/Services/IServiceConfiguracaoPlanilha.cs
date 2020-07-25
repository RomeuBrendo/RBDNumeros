using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services.Base;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceConfiguracaoPlanilha : IServiceBase
    {
        void Adicionar(AdicionarConfiguracaoPlanilhaRequest request);
    }
}
