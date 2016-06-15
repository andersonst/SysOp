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
    public class ItemPedidoCompraAppService : AppServiceBase<ItemPedidoCompra>, IItemPedidoCompraAppService
    {
        private readonly IItemPedidoCompraService _itemPedidoCompraService;

        public ItemPedidoCompraAppService(IItemPedidoCompraService itemPedidoCompraService)
            : base(itemPedidoCompraService)
        {
            _itemPedidoCompraService = itemPedidoCompraService;
        }
    }
}
