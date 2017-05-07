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
    public class ItemEstoqueService : ServiceBase<ItemEstoque>, IItemEstoqueService
    {
        private readonly IItemEstoqueRepository _itemEstoqueRepository;

        public ItemEstoqueService(IItemEstoqueRepository itemEstoqueRepository)
            : base(itemEstoqueRepository)
        {
            _itemEstoqueRepository = itemEstoqueRepository;
        }
    }
}
