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
    public class ItemSolicitacaoCompraApp : AppServiceBase<ItemSolicitacaoCompra>, IItemSolicitacaoCompraAppService
    {
        private readonly IItemSolicitacaoCompraService _itemSolicitacaoCompraService;

        public ItemSolicitacaoCompraApp(IItemSolicitacaoCompraService itemSolicitacaoCompraService)
            :base(itemSolicitacaoCompraService)
        {
            _itemSolicitacaoCompraService = itemSolicitacaoCompraService;
        }
    }
}
