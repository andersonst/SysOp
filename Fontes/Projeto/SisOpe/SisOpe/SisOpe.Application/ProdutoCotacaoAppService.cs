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
    public class ProdutoCotacaoAppService : AppServiceBase<ProdutoCotacao>, IProdutoCotacaoAppService
    {
        private readonly IProdutoCotacaoService _produtoCotacaoService;

        public ProdutoCotacaoAppService(IProdutoCotacaoService produtoCotacaoService)
            :base(produtoCotacaoService)
        {
            _produtoCotacaoService = produtoCotacaoService;
        }
    }
}
