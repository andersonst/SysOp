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
    public class StatusCotacaoAppService : AppServiceBase<StatusCotacao>, IStatusCotacaoAppService
    {
        private readonly IStatusCotacaoService _statusCotacaoService;

        public StatusCotacaoAppService(IStatusCotacaoService statusCotacaoService)
            :base(statusCotacaoService)
        {
            _statusCotacaoService = statusCotacaoService;
        }
    }
}
