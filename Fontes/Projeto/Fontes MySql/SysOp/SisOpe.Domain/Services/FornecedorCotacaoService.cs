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
    public class FornecedorCotacaoService : ServiceBase<FornecedorCotacao>, IFornecedorCotacaoService
    {
        private readonly IFornecedorCotacaoRepository _fornecedorCotacaoRepository;

        public FornecedorCotacaoService(IFornecedorCotacaoRepository fornecedorCotacaoRepository)
            : base(fornecedorCotacaoRepository)
        {
            _fornecedorCotacaoRepository = fornecedorCotacaoRepository;
        }
    }
}
