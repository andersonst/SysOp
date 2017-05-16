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
    public class ItemPedidoCompraCotacaoApp : AppServiceBase<ItemPedidoCompraCotacao>, IItemPedidoCompraCotacaoAppService
    {
        private readonly IItemPedidoCompraCotacaoService _itemPedidoCompraCotacaoService;

        public ItemPedidoCompraCotacaoApp(IItemPedidoCompraCotacaoService itemPedidoCompraCotacaoService)
            :base(itemPedidoCompraCotacaoService)
        {
            _itemPedidoCompraCotacaoService = itemPedidoCompraCotacaoService;
        }
    }
}
