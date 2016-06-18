using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;

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
