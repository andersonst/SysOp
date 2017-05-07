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
    public class ItemVendaApp : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEstoqueService;

        public ItemVendaApp(IItemVendaEstoqueService itemVendaEstoqueService)
            :base(itemVendaEstoqueService)
        {
            _itemVendaEstoqueService = itemVendaEstoqueService;
        }
    }
}
