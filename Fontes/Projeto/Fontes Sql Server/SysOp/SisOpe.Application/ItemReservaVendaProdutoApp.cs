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
    public class ItemReservaVendaProdutoApp : AppServiceBase<ItemVendaEstoque>, IItemReservaVendaProdutoAppService
    {
        private readonly IItemReservaVendaProdutoService _ìtemReservaVendaProdutoService;

        public ItemReservaVendaProdutoApp(IItemReservaVendaProdutoService ìtemReservaVendaProdutoService)
            : base(ìtemReservaVendaProdutoService)
        {
            _ìtemReservaVendaProdutoService = ìtemReservaVendaProdutoService;
        }
    }
}
