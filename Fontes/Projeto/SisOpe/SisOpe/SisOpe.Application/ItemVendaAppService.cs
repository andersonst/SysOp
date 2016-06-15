using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class ItemVendaAppService : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEstoqueService;

        public ItemVendaAppService(IItemVendaEstoqueService itemVendaEstoqueService)
            :base(itemVendaEstoqueService)
        {
            _itemVendaEstoqueService = itemVendaEstoqueService;
        }
    }
}
