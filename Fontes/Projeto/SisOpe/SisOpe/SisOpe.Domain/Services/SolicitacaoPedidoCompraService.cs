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
    public class SolicitacaoPedidoCompraService : ServiceBase<SolicitacaoPedidoCompra>, ISolicitacaoPedidoCompraService
    {
        private readonly ISolicitacaoPedidoCompraRepository _solicitacaoPedidoCompraRepository;

        public SolicitacaoPedidoCompraService(ISolicitacaoPedidoCompraRepository solicitacaoPedidoCompraRepository)
            :base(solicitacaoPedidoCompraRepository)
        {
            _solicitacaoPedidoCompraRepository = solicitacaoPedidoCompraRepository;
        }
    }
}
