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
    public class TipoProdutoApp : AppServiceBase<TipoProduto>, ITipoProdutoAppService
    {
        private readonly ITipoProdutoService _tipoProdutoService;

        public TipoProdutoApp(ITipoProdutoService tipoProdutoService)
            :base(tipoProdutoService)
        {
            _tipoProdutoService = tipoProdutoService;
        }
    }
}
