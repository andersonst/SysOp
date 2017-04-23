using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class ItemVendaEstoqueService : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEtoqueService;

        public ItemVendaEstoqueService(IItemVendaEstoqueService itemVendaEtoqueService)
            : base(itemVendaEtoqueService)
        {
            _itemVendaEtoqueService = itemVendaEtoqueService;
        }


    }
}
