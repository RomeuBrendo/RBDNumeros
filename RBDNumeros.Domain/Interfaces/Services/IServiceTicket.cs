using RBDNumeros.Domain.Interfaces.Services.Base;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceTicket : IServiceBase
    {
        int ImportarCsv(string caminho);
        int RetornaPorcentagem();
        string RetornaProcesso();
        void CancelarImportacao();

        int RetorneNumerosCarteira(int Carteira);
    }
}
