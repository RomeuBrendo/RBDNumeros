using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Entities;
using RBDNumeros.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBDNumeros.Domain.Interfaces.Services
{
    public interface IServiceSla : IServiceBase
    {
        bool InserirAlterar(AdicionarAlterarSlaRequest adicionarAlterarSlaRequest);
        SlaResponse ObterRegistro();
    }
}
