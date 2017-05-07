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
    public class HistoricoStatusCotacaoApp : AppServiceBase<HistoricoStatusCotacao>, IHistoricoStatusCotacaoAppService
    {
        private readonly IHistoricoStatusCotacaoService _historicoStatusCotacaoService;

        public HistoricoStatusCotacaoApp(IHistoricoStatusCotacaoService historicoStatusCotacaoService)
            :base(historicoStatusCotacaoService)
        {
            _historicoStatusCotacaoService = historicoStatusCotacaoService;
        }
    }
}
