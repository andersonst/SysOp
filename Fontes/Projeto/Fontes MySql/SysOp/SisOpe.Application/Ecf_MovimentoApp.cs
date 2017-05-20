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
    public class Ecf_MovimentoApp : AppServiceBase<Ecf_Movimento>, IEcf_MovimentoAppService
    {
        private readonly IEcf_MovimentoService _ecf_MovimentoService;

        public Ecf_MovimentoApp(IEcf_MovimentoService ecf_MovimentoService)
            : base(ecf_MovimentoService)
        {
            _ecf_MovimentoService = ecf_MovimentoService;
        }
    }
}
