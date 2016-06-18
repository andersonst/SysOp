using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class ItemVendaAppService : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEstoqueService;

        public ItemVendaAppService(IItemVendaEstoqueService itemVendaEstoqueService)
            :base(itemVendaEstoqueService)
        {
            _itemVendaEstoqueService = itemVendaEstoqueService;
        }
    }
}
