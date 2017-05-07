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
    public class PagamentoPedidoCompraApp : AppServiceBase<PagamentoPedidoCompra>, IPagamentoPedidoCompraAppService
    {
        private readonly IPagamentoPedidoCompraService _pagamentoPedidoCompraService;

        public PagamentoPedidoCompraApp(IPagamentoPedidoCompraService pagamentoPedidoCompraService)
            : base(pagamentoPedidoCompraService)
        {
            _pagamentoPedidoCompraService = pagamentoPedidoCompraService;
        }
    }
}
