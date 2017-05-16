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
    public class Ecf_ResolucaoApp : AppServiceBase<Ecf_Resolucao>, IEcf_ResolucaoAppService
    {
        private readonly IEcf_ResolucaoService _ecf_ResolucaoService;

        public Ecf_ResolucaoApp(IEcf_ResolucaoService ecf_ResolucaoService)
            : base(ecf_ResolucaoService)
        {
            _ecf_ResolucaoService = ecf_ResolucaoService;
        }
    }
}
