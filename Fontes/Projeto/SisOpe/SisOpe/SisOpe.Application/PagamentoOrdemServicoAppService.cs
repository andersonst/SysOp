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
    public class PagamentoOrdemServicoAppService : AppServiceBase<PagamentoOrdemServico>, IPagamentoOrdemServicoAppService
    {
        private readonly IPagamentoOrdemServicoService _pagamentoOrdemServicoService;

        public PagamentoOrdemServicoAppService(IPagamentoOrdemServicoService pagamentoOrdemServicoService)
            :base(pagamentoOrdemServicoService)
        {
            _pagamentoOrdemServicoService = pagamentoOrdemServicoService;
        }
    }
}
