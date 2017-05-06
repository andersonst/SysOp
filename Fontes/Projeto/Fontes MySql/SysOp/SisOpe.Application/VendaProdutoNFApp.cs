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
    public class VendaProdutoNFApp : AppServiceBase<VendaProdutoNF>, IVendaProdutoNFAppService
    {
        private readonly IVendaProdutoNFService _vendaProdutoNFService;

        public VendaProdutoNFApp(IVendaProdutoNFService vendaProdutoNFService)
            :base(vendaProdutoNFService)
        {
            _vendaProdutoNFService = vendaProdutoNFService;
        }
    }
}
