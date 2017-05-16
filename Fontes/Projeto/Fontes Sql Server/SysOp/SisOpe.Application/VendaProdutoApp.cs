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
    public class VendaProdutoApp : AppServiceBase<VendaProduto>, IVendaProdutoAppService
    {
        private readonly IVendaProdutoService _vendaProdutoService;

        public VendaProdutoApp(IVendaProdutoService vendaProdutoService)
            :base(vendaProdutoService)
        {
            _vendaProdutoService = vendaProdutoService;
        }
    }
}
