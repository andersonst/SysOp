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
    public class ItemEntradaEstoqueService : ServiceBase<ItemEntradaEstoque>, IItemEntradaEstoqueService
    {
        private readonly IItemEntradaEstoqueRepository _itemEntradaEstoqueRepository;

        public ItemEntradaEstoqueService(IItemEntradaEstoqueRepository itemEntradaEstoqueRepository)
            :base(itemEntradaEstoqueRepository)
        {
            _itemEntradaEstoqueRepository = itemEntradaEstoqueRepository;
        }
    }
}
