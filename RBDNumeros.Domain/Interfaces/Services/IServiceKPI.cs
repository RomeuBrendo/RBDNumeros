using RBDNumeros.Domain.Commands.KPI;
using RBDNumeros.Domain.Entities.KPI;
using RBDNumeros.Domain.Interfaces.Services.Base;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceKPI : IServiceBase
    {
        ChamadosPorCarteira ChamadosPorCarteira(ChamadosPorCarteiraRequest request);
    }
}
