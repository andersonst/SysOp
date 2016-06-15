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
    public class SolicitacaoPedidoCompraAppService : AppServiceBase<SolicitacaoPedidoCompra>, ISolicitacaoPedidoCompraAppService
    {
        private readonly ISolicitacaoPedidoCompraService _solicitacaoPedidoCompraService;

        public SolicitacaoPedidoCompraAppService(ISolicitacaoPedidoCompraService solicitacaoPedidoCompraService)
            :base(solicitacaoPedidoCompraService)
        {
            _solicitacaoPedidoCompraService = solicitacaoPedidoCompraService;
        }
    }
}
