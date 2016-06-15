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
    public class UnidadeMedidaAppService : AppServiceBase<UnidadeMedida>, IUnidadeMedidaAppService
    {
        private readonly IUnidadeMedidaService _unidadeMedidaService;

        public UnidadeMedidaAppService(IUnidadeMedidaService unidadeMedidaService)
            :base(unidadeMedidaService)
        {
            _unidadeMedidaService = unidadeMedidaService;
        }
    }
}
