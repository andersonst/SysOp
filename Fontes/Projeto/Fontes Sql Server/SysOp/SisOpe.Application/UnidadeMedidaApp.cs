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
    public class UnidadeMedidaApp : AppServiceBase<UnidadeMedida>, IUnidadeMedidaAppService
    {
        private readonly IUnidadeMedidaService _unidadeMedidaService;

        public UnidadeMedidaApp(IUnidadeMedidaService unidadeMedidaService)
            :base(unidadeMedidaService)
        {
            _unidadeMedidaService = unidadeMedidaService;
        }
    }
}
