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
    public class HistoricoOrdemServicoAppService : AppServiceBase<HistoricoOrdemServico>, IHistoricoOrdemServicoAppService
    {
        private readonly IHistoricoOrdemServicoService _historicoOrdemServicoService;

        public HistoricoOrdemServicoAppService(IHistoricoOrdemServicoService historicoOrdemServicoService)
            : base(historicoOrdemServicoService)
        {
            _historicoOrdemServicoService = historicoOrdemServicoService;
        }
    }
}
