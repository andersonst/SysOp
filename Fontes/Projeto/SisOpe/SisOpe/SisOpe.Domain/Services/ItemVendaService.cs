﻿using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Domain.Services
{
    public class ItemVendaService : ServiceBase<ItemVendaEstoque>, IItemVendaEstoqueService
    {
        private readonly IItemVendaEstoqueRepository _itemVendaEstoqueRepository;

        public ItemVendaService(IItemVendaEstoqueRepository itemVendaEstoqueRepository)
            :base(itemVendaEstoqueRepository)
        {
            _itemVendaEstoqueRepository = itemVendaEstoqueRepository;
        }
    }
}