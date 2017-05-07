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
    public class PagamentoOrdemServicoApp : AppServiceBase<PagamentoOrdemServico>, IPagamentoOrdemServicoAppService
    {
        private readonly IPagamentoOrdemServicoService _pagamentoOrdemServicoService;

        public PagamentoOrdemServicoApp(IPagamentoOrdemServicoService pagamentoOrdemServicoService)
            :base(pagamentoOrdemServicoService)
        {
            _pagamentoOrdemServicoService = pagamentoOrdemServicoService;
        }
    }
}
