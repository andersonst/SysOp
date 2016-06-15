using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class StatusOrdemServicoAppService : AppServiceBase<StatusOrdemServico>, IStatusOrdemServicoAppService
    {
        private readonly IStatusOrdemServicoService _statusOrdemServicoService;

        public StatusOrdemServicoAppService(IStatusOrdemServicoService statusOrdemServicoService)
            :base(statusOrdemServicoService)
        {
            _statusOrdemServicoService = statusOrdemServicoService;
        }
    }
}
