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
    public class StatusCotacaoService : ServiceBase<StatusCotacao>, IStatusCotacaoService
    {
        private readonly IStatusCotacaoRepository _statusCotacaoRepository;

        public StatusCotacaoService(IStatusCotacaoRepository statusCotacaoRepository)
            :base(statusCotacaoRepository)
        {
            _statusCotacaoRepository = statusCotacaoRepository;
        }
    }
}
