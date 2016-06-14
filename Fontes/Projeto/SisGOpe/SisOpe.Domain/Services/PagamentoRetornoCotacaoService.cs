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
    public class PagamentoRetornoCotacaoService : ServiceBase<PagamentoRetornoCotacao>, IPagamentoRetornoCotacaoService
    {
        private readonly IPagamentoRetornoCotacaoRepository _pagamentoRetornoCotacaoRepository;

        public PagamentoRetornoCotacaoService(IPagamentoRetornoCotacaoRepository pagamentoRetornoCotacaoRepository)
            :base(pagamentoRetornoCotacaoRepository)
        {
            _pagamentoRetornoCotacaoRepository = pagamentoRetornoCotacaoRepository;
        }
    }
}
