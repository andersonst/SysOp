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
    public class ItemEstoqueAppService : AppServiceBase<ItemEstoque>, IItemEstoqueAppService
    {
        private readonly IItemEstoqueService _itemEstoqueService;

        public ItemEstoqueAppService(IItemEstoqueService itemEstoqueService)
            : base(itemEstoqueService)
        {
            _itemEstoqueService = itemEstoqueService;
        }
    }
}
