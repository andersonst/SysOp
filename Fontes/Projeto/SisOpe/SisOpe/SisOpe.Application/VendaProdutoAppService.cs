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
    public class VendaProdutoAppService : AppServiceBase<VendaProduto>, IVendaProdutoAppService
    {
        private readonly IVendaProdutoService _vendaProdutoService;

        public VendaProdutoAppService(IVendaProdutoService vendaProdutoService)
            :base(vendaProdutoService)
        {
            _vendaProdutoService = vendaProdutoService;
        }
    }
}
