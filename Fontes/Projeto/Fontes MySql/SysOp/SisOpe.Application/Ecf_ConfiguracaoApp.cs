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
    public class Ecf_ConfiguracaoApp : AppServiceBase<Ecf_Configuracao>, IEcf_ConfiguracaoAppService
    {
        private readonly IEcf_ConfiguracaoService _ecf_ConfiguracaoService;

        public Ecf_ConfiguracaoApp(IEcf_ConfiguracaoService ecf_ConfiguracaoService)
            : base(ecf_ConfiguracaoService)
        {
            _ecf_ConfiguracaoService = ecf_ConfiguracaoService;
        }
    }
}
