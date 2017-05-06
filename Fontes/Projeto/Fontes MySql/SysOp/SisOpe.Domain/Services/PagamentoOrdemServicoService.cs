using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class PagamentoOrdemServicoService : ServiceBase<PagamentoOrdemServico>, IPagamentoOrdemServicoService
    {
        private readonly IPagamentoOrdemServicoRepository _pagamentoOrdemServicoRepository;

        public PagamentoOrdemServicoService(IPagamentoOrdemServicoRepository pagamentoOrdemServicoRepository)
            :base(pagamentoOrdemServicoRepository)
        {
            _pagamentoOrdemServicoRepository = pagamentoOrdemServicoRepository;
        }
    }
}
