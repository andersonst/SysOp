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
    public class FornecedorCotacaoAppService : AppServiceBase<FornecedorCotacao>, IFornecedorCotacaoAppService
    {
        private readonly IFornecedorCotacaoService _fornecedorCotacaoService;

        public FornecedorCotacaoAppService(IFornecedorCotacaoService fornecedorCotacaoService)
            : base(fornecedorCotacaoService)
        {
            _fornecedorCotacaoService = fornecedorCotacaoService;
        }
    }
}
