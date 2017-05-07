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
    public class FornecedorCotacaoApp : AppServiceBase<FornecedorCotacao>, IFornecedorCotacaoAppService
    {
        private readonly IFornecedorCotacaoService _fornecedorCotacaoService;

        public FornecedorCotacaoApp(IFornecedorCotacaoService fornecedorCotacaoService)
            : base(fornecedorCotacaoService)
        {
            _fornecedorCotacaoService = fornecedorCotacaoService;
        }
    }
}
