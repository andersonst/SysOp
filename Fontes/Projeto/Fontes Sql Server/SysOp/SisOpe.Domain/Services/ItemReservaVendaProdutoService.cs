﻿using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class ItemReservaVendaProdutoService : ServiceBase<ItemVendaEstoque>, IItemReservaVendaProdutoService
    {
        private readonly IItemReservaVendaProdutoRepository _ìtemReservaVendaProdutoRepository;

        public ItemReservaVendaProdutoService(IItemReservaVendaProdutoRepository ìtemReservaVendaProdutoRepository)
            : base(ìtemReservaVendaProdutoRepository)
        {
            _ìtemReservaVendaProdutoRepository = ìtemReservaVendaProdutoRepository;
        }
    }
}
