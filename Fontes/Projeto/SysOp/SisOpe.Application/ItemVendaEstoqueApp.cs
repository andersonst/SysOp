using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class ItemVendaEstoqueApp : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEstoqueService;

        public ItemVendaEstoqueApp(IItemVendaEstoqueService itemVendaEstoqueService)
            : base(itemVendaEstoqueService)
        {
            _itemVendaEstoqueService = itemVendaEstoqueService;
        } 



    }
}
