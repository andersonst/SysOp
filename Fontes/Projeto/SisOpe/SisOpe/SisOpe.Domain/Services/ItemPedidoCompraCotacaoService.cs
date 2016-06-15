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
    public class ItemPedidoCompraCotacaoService : ServiceBase<ItemPedidoCompraCotacao>, IItemPedidoCompraCotacaoService
    {
        private readonly IItemPedidoCompraCotacaoRepository _itemPedidoCompraCotacaoRepository;

        public ItemPedidoCompraCotacaoService(IItemPedidoCompraCotacaoRepository itemPedidoCompraCotacaoRepository)
            :base(itemPedidoCompraCotacaoRepository)
        {
            _itemPedidoCompraCotacaoRepository = itemPedidoCompraCotacaoRepository;
        }
    }
}
