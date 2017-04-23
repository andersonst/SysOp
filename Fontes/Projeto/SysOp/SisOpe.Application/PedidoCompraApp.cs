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
    public class PedidoCompraApp : AppServiceBase<PedidoCompra>, IPedidoCompraAppService
    {
        private readonly IPedidoCompraService _pedidoCompraService;

        public PedidoCompraApp(IPedidoCompraService pedidoCompraService)
            : base(pedidoCompraService)
        {
            _pedidoCompraService = pedidoCompraService;
        }
    }
}
