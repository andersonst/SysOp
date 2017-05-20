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
    public class Ecf_CaixaApp : AppServiceBase<Ecf_Caixa>, IEcf_CaixaAppService
    {
        private readonly IEcf_CaixaService _ecf_CaixaService;

        public Ecf_CaixaApp(IEcf_CaixaService ecf_CaixaService)
            : base(ecf_CaixaService)
        {
            _ecf_CaixaService = ecf_CaixaService;
        }
    }
}
