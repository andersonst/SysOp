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
    public class ItemPedidoCompraCotacaoAppService : AppServiceBase<ItemPedidoCompraCotacao>, IItemPedidoCompraCotacaoAppService
    {
        private readonly IItemPedidoCompraCotacaoService _itemPedidoCompraCotacaoService;

        public ItemPedidoCompraCotacaoAppService(IItemPedidoCompraCotacaoService itemPedidoCompraCotacaoService)
            :base(itemPedidoCompraCotacaoService)
        {
            _itemPedidoCompraCotacaoService = itemPedidoCompraCotacaoService;
        }
    }
}
