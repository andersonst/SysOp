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
    public class UnidadeMedidaService : ServiceBase<UnidadeMedida>, IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _unidadeMedidaRepository;

        public UnidadeMedidaService(IUnidadeMedidaRepository unidadeMedidaRepository)
            :base(unidadeMedidaRepository)
        {
            _unidadeMedidaRepository = unidadeMedidaRepository;
        }
    }
}
