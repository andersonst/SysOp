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
    public class ItemProdutoNotaFiscalApp : AppServiceBase<ItemProdutoNotaFiscal>, IItemProdutoNotaFiscalAppService
    {
        private readonly IItemProdutoNotaFiscalService _itemProdutoNotaFiscalService;

        public ItemProdutoNotaFiscalApp(IItemProdutoNotaFiscalService itemProdutoNotaFiscalService)
            :base(itemProdutoNotaFiscalService)
        {
            _itemProdutoNotaFiscalService = itemProdutoNotaFiscalService;
        }
    }
}
