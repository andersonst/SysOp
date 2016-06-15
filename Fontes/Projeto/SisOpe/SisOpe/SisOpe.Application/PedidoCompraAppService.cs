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
    public class PedidoCompraAppService : AppServiceBase<PedidoCompra>, IPedidoCompraAppService
    {
        private readonly IPedidoCompraService _pedidoCompraService;

        public PedidoCompraAppService(IPedidoCompraService pedidoCompraService)
            : base(pedidoCompraService)
        {
            _pedidoCompraService = pedidoCompraService;
        }
    }
}
