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
    public class VendaProdutoNFService : ServiceBase<VendaProdutoNF>, IVendaProdutoNFService
    {
        private readonly IVendaProdutoNFRepository _vendaProdutoNFRepository;

        public VendaProdutoNFService(IVendaProdutoNFRepository vendaProdutoNFRepository)
            :base(vendaProdutoNFRepository)
        {
            _vendaProdutoNFRepository = vendaProdutoNFRepository;
        }
    }
}
