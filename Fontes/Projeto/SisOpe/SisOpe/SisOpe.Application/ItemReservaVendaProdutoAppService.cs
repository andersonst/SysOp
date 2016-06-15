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
    public class ItemReservaVendaProdutoAppService : AppServiceBase<ItemReservaVendaProduto>, IItemReservaVendaProdutoAppService
    {
        private readonly IItemReservaVendaProdutoService _ìtemReservaVendaProdutoService;

        public ItemReservaVendaProdutoAppService(IItemReservaVendaProdutoService ìtemReservaVendaProdutoService)
            : base(ìtemReservaVendaProdutoService)
        {
            _ìtemReservaVendaProdutoService = ìtemReservaVendaProdutoService;
        }
    }
}
