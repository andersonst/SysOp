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
    public class ReservaApp : AppServiceBase<Reserva>, IReservaAppService
    {
        private readonly IReservaService _reservaService;

        public ReservaApp(IReservaService reservaService)
            :base(reservaService)
        {
            _reservaService = reservaService;
        }
    }
}
