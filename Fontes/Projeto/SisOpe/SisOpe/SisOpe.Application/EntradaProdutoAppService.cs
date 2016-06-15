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
    public class EntradaProdutoAppService : AppServiceBase<EntradaProduto>, IEntradaProdutoAppService
    {
        private readonly IEntradaProdutoService _entradaProdutoService;

        public EntradaProdutoAppService(IEntradaProdutoService entradaProdutoService)
            : base(entradaProdutoService)
        {
            _entradaProdutoService = entradaProdutoService;
        }
    }
}
