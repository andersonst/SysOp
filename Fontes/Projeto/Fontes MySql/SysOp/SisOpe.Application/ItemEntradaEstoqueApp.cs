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
    public class ItemEntradaEstoqueApp : AppServiceBase<ItemEntradaEstoque>, IItemEntradaEstoqueAppService
    {
        private readonly IItemEntradaEstoqueService _itemEntradaEstoqueService;

        public ItemEntradaEstoqueApp(IItemEntradaEstoqueService itemEntradaEstoqueService)
            :base(itemEntradaEstoqueService)
        {
            _itemEntradaEstoqueService = itemEntradaEstoqueService;
        }
    }
}
