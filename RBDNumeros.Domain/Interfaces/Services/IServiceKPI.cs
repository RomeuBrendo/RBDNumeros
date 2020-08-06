using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities.KPI;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceKPI : IServiceBase
    {
        ChamadosPorCarteira ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim);
        List<ChamadosPorSlaRequest> ChamadosPorSla(DateTime dataInicio, DateTime dataFim);
    }
}
