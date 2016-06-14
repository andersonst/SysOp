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
    public class HistoricoStatusCotacaoService : ServiceBase<HistoricoStatusCotacao>, IHistoricoStatusCotacaoService
    {
        private readonly IHistoricoStatusCotacaoRepository _historicoStatusCotacaoRepository;

        public HistoricoStatusCotacaoService(IHistoricoStatusCotacaoRepository historicoStatusCotacaoRepository)
            :base(historicoStatusCotacaoRepository)
        {
            _historicoStatusCotacaoRepository = historicoStatusCotacaoRepository;
        }
    }
}
