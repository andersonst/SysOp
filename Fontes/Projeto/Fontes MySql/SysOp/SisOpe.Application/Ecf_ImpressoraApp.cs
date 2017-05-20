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
    public class Ecf_ImpressoraApp : AppServiceBase<Ecf_Impressora>, IEcf_ImpressoraAppService
    {
        private readonly IEcf_ImpressoraService _ecf_ImpressoraService;

        public Ecf_ImpressoraApp(IEcf_ImpressoraService ecf_ImpressoraService)
            : base(ecf_ImpressoraService)
        {
            _ecf_ImpressoraService = ecf_ImpressoraService;
        }
    }
}
