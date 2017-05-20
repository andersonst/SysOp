using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class Ecf_OperadorApp : AppServiceBase<Ecf_Operador>, IEcf_OperadorAppService
    {
        private readonly IEcf_OperadorService _ecf_OperadorService;

        public Ecf_OperadorApp(IEcf_OperadorService ecf_OperadorService)
            : base(ecf_OperadorService)

        {
            _ecf_OperadorService = ecf_OperadorService;
        }
    }
}
