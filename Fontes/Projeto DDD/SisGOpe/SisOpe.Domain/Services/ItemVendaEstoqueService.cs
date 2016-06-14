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
    public class ItemVendaEstoqueService : ServiceBase<ItemVendaEstoque>, IItemVendaEstoqueService
    {
        private readonly IItemVendaEstoqueRepository _itemVendaEtoqueRepository;

        public ItemVendaEstoqueService(IItemVendaEstoqueRepository itemVendaEtoqueRepository)
            : base(itemVendaEtoqueRepository)
        {
            _itemVendaEtoqueRepository = itemVendaEtoqueRepository;
        }


    }
}
