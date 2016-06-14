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
    public class PagamentoPedidoCompraService : ServiceBase<PagamentoPedidoCompra>, IPagamentoPedidoCompraService
    {
        private readonly IPagamentoPedidoCompraRepository _pagamentoPedidoCompraRepository;

        public PagamentoPedidoCompraService(IPagamentoPedidoCompraRepository pagamentoPedidoCompraRepository)
            : base(pagamentoPedidoCompraRepository)
        {
            _pagamentoPedidoCompraRepository = pagamentoPedidoCompraRepository;
        }
    }
}
