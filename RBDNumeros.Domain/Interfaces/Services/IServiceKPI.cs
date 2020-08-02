using RBDNumeros.Domain.Entities.KPI;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceKPI : IServiceBase
    {
        ChamadosPorCarteira ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim);
    }
}
