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
    public class ProdutoApp : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoApp(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }
    }
}
