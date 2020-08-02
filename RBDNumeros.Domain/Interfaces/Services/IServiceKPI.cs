using RBDNumeros.Domain.Entities.KPI;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceKPI : IServiceBase
    {
        ChamadosPorCarteira ChamadosPorCarteira(DateTime dataInicio, DateTime dataFim);
    }
}
