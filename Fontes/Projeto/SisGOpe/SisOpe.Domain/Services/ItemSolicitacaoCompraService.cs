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
    public class ItemSolicitacaoCompraService : ServiceBase<ItemSolicitacaoCompra>, IItemSolicitacaoCompraService
    {
        private readonly IItemSolicitacaoCompraRepository _itemSolicitacaoCompraRepository;

        public ItemSolicitacaoCompraService(IItemSolicitacaoCompraRepository itemSolicitacaoCompraRepository)
            :base(itemSolicitacaoCompraRepository)
        {
            _itemSolicitacaoCompraRepository = itemSolicitacaoCompraRepository;
        }
    }
}
