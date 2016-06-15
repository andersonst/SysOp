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
    public class ItemTransferenciaEstoqueAppService : AppServiceBase<ItemTransferenciaEstoque>, IItemTransferenciaEstoqueAppService
    {
        private readonly IItemTransferenciaEstoqueService _itemTransferenciaEstoqueService;

        public ItemTransferenciaEstoqueAppService(IItemTransferenciaEstoqueService itemTransferenciaEstoqueService)
            :base(itemTransferenciaEstoqueService)
        {
            _itemTransferenciaEstoqueService = itemTransferenciaEstoqueService;
        }
    }
}
