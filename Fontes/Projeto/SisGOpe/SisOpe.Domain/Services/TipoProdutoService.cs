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
    public class TipoProdutoService : ServiceBase<TipoProduto>, ITipoProdutoService
    {
        private readonly ITipoProdutoRepository _tipoProdutoRepository;

        public TipoProdutoService(ITipoProdutoRepository tipoProdutoRepository)
            :base(tipoProdutoRepository)
        {
            _tipoProdutoRepository = tipoProdutoRepository;
        }
    }
}
