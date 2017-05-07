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
    public class ItemPedidoCompraApp : AppServiceBase<ItemPedidoCompra>, IItemPedidoCompraAppService
    {
        private readonly IItemPedidoCompraService _itemPedidoCompraService;

        public ItemPedidoCompraApp(IItemPedidoCompraService itemPedidoCompraService)
            : base(itemPedidoCompraService)
        {
            _itemPedidoCompraService = itemPedidoCompraService;
        }
    }
}
