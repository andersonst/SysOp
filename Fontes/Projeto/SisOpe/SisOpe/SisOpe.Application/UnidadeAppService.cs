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
    public class UnidadeAppService : AppServiceBase<Unidade>, IUnidadeAppService
    {
        private readonly IUnidadeService _unidadeService;

        public UnidadeAppService(IUnidadeService unidadeService)
            :base(unidadeService)
        {
            _unidadeService = unidadeService;
        }
    }
}
