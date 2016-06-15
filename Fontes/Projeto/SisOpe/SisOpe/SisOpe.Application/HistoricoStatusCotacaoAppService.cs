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
    public class HistoricoStatusCotacaoAppService : AppServiceBase<HistoricoStatusCotacao>, IHistoricoStatusCotacaoAppService
    {
        private readonly IHistoricoStatusCotacaoService _historicoStatusCotacaoService;

        public HistoricoStatusCotacaoAppService(IHistoricoStatusCotacaoService historicoStatusCotacaoService)
            :base(historicoStatusCotacaoService)
        {
            _historicoStatusCotacaoService = historicoStatusCotacaoService;
        }
    }
}
