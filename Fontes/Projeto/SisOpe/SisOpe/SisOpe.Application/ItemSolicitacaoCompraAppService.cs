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
    public class ItemSolicitacaoCompraAppService : AppServiceBase<ItemSolicitacaoCompra>, IItemSolicitacaoCompraAppService
    {
        private readonly IItemSolicitacaoCompraService _itemSolicitacaoCompraService;

        public ItemSolicitacaoCompraAppService(IItemSolicitacaoCompraService itemSolicitacaoCompraService)
            :base(itemSolicitacaoCompraService)
        {
            _itemSolicitacaoCompraService = itemSolicitacaoCompraService;
        }
    }
}
