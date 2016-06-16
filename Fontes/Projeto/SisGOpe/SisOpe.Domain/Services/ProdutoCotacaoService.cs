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
    public class ProdutoCotacaoService : ServiceBase<ProdutoCotacao>, IProdutoCotacaoService
    {
        private readonly IProdutoCotacaoRepository _produtoCotacaoRepository;

        public ProdutoCotacaoService(IProdutoCotacaoRepository produtoCotacaoRepository)
            :base(produtoCotacaoRepository)
        {
            _produtoCotacaoRepository = produtoCotacaoRepository;
        }
    }
}
