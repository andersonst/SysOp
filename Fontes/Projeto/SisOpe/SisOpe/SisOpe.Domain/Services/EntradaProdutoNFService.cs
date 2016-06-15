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
    public class EntradaProdutoNFService : ServiceBase<EntradaProdutoNF>, IEntradaProdutoNFService
    {
        private readonly IEntradaProdutoNFRepository _entradaProdutoNFRepository;

        public EntradaProdutoNFService(IEntradaProdutoNFRepository entradaProdutoNFRepository)
            :base(entradaProdutoNFRepository)
        {
            _entradaProdutoNFRepository = entradaProdutoNFRepository;
        }
    }
}
