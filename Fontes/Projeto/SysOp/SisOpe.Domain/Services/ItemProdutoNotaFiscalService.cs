using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class ItemProdutoNotaFiscalService : ServiceBase<ItemProdutoNotaFiscal>, IItemProdutoNotaFiscalService
    {
        private readonly IItemProdutoNotaFiscalRepository _itemProdutoNotaFiscalRepository;

        public ItemProdutoNotaFiscalService(IItemProdutoNotaFiscalRepository itemProdutoNotaFiscalRepository)
            :base(itemProdutoNotaFiscalRepository)
        {
            _itemProdutoNotaFiscalRepository = itemProdutoNotaFiscalRepository;
        }
    }
}
