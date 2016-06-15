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
    public class TipoProdutoAppService : AppServiceBase<TipoProduto>, ITipoProdutoAppService
    {
        private readonly ITipoProdutoService _tipoProdutoService;

        public TipoProdutoAppService(ITipoProdutoService tipoProdutoService)
            :base(tipoProdutoService)
        {
            _tipoProdutoService = tipoProdutoService;
        }
    }
}
