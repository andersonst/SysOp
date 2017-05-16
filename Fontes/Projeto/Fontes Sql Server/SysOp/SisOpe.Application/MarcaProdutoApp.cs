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
    public class MarcaProdutoApp : AppServiceBase<MarcaProduto>, IMarcaProdutoAppService
    {
        private readonly IMarcaProdutoService _marcaProdutoService;

        public MarcaProdutoApp(IMarcaProdutoService marcaProdutoService)
            :base(marcaProdutoService)
        {
            _marcaProdutoService = marcaProdutoService;
        }
    }
}
