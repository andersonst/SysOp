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
    public class ItemTransferenciaEstoqueApp : AppServiceBase<ItemTransferenciaEstoque>, IItemTransferenciaEstoqueAppService
    {
        private readonly IItemTransferenciaEstoqueService _itemTransferenciaEstoqueService;

        public ItemTransferenciaEstoqueApp(IItemTransferenciaEstoqueService itemTransferenciaEstoqueService)
            :base(itemTransferenciaEstoqueService)
        {
            _itemTransferenciaEstoqueService = itemTransferenciaEstoqueService;
        }
    }
}
