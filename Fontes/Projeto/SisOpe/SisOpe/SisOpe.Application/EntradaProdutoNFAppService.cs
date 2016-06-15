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
    public class EntradaProdutoNFAppService : AppServiceBase<EntradaProdutoNF>, IEntradaProdutoNFAppService
    {
        private readonly IEntradaProdutoNFService _entradaProdutoNFService;

        public EntradaProdutoNFAppService(IEntradaProdutoNFService entradaProdutoNFService)
            :base(entradaProdutoNFService)
        {
            _entradaProdutoNFService = entradaProdutoNFService;
        }
    }
}
