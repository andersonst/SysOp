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
    public class MarcaProdutoAppService : AppServiceBase<MarcaProduto>, IMarcaProdutoAppService
    {
        private readonly IMarcaProdutoService _marcaProdutoService;

        public MarcaProdutoAppService(IMarcaProdutoService marcaProdutoService)
            :base(marcaProdutoService)
        {
            _marcaProdutoService = marcaProdutoService;
        }
    }
}
