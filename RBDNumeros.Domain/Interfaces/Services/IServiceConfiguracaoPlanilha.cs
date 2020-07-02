using RBDNumeros.Domain.Commands;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceConfiguracaoPlanilha 
    {
        void Adicionar(AdicionarConfiguracaoPlanilhaRequest request);
    }
}
