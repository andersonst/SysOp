using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
