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
    public class ItemEntradaEstoqueAppService : AppServiceBase<ItemEntradaEstoque>, IItemEntradaEstoqueAppService
    {
        private readonly IItemEntradaEstoqueService _itemEntradaEstoqueService;

        public ItemEntradaEstoqueAppService(IItemEntradaEstoqueService itemEntradaEstoqueService)
            :base(itemEntradaEstoqueService)
        {
            _itemEntradaEstoqueService = itemEntradaEstoqueService;
        }
    }
}
