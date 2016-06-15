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
    public class PagamentoRetornoCotacaoAppService : AppServiceBase<PagamentoRetornoCotacao>, IPagamentoRetornoCotacaoAppService
    {
        private readonly IPagamentoRetornoCotacaoService _pagamentoRetornoCotacaoService;

        public PagamentoRetornoCotacaoAppService(IPagamentoRetornoCotacaoService pagamentoRetornoCotacaoService)
            :base(pagamentoRetornoCotacaoService)
        {
            _pagamentoRetornoCotacaoService = pagamentoRetornoCotacaoService;
        }
    }
}
