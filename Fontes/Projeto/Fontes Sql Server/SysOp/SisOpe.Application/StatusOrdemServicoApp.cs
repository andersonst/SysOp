using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class StatusOrdemServicoApp : AppServiceBase<StatusOrdemServico>, IStatusOrdemServicoAppService
    {
        private readonly IStatusOrdemServicoService _statusOrdemServicoService;

        public StatusOrdemServicoApp(IStatusOrdemServicoService statusOrdemServicoService)
            :base(statusOrdemServicoService)
        {
            _statusOrdemServicoService = statusOrdemServicoService;
        }
    }
}
