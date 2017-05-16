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
    public class StatusCotacaoApp : AppServiceBase<StatusCotacao>, IStatusCotacaoAppService
    {
        private readonly IStatusCotacaoService _statusCotacaoService;

        public StatusCotacaoApp(IStatusCotacaoService statusCotacaoService)
            :base(statusCotacaoService)
        {
            _statusCotacaoService = statusCotacaoService;
        }
    }
}
