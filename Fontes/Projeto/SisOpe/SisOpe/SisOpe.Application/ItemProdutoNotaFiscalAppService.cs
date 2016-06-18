﻿using SisOpe.Application.Interfaces;
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
    public class ItemProdutoNotaFiscalAppService : AppServiceBase<ItemProdutoNotaFiscal>, IItemProdutoNotaFiscalAppService
    {
        private readonly IItemProdutoNotaFiscalService _itemProdutoNotaFiscalService;

        public ItemProdutoNotaFiscalAppService(IItemProdutoNotaFiscalService itemProdutoNotaFiscalService)
            :base(itemProdutoNotaFiscalService)
        {
            _itemProdutoNotaFiscalService = itemProdutoNotaFiscalService;
        }
    }
}