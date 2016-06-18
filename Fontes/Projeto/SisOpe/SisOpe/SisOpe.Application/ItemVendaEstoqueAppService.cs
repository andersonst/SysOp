using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class ItemVendaEstoqueAppService : AppServiceBase<ItemVendaEstoque>, IItemVendaEstoqueAppService
    {
        private readonly IItemVendaEstoqueService _itemVendaEstoqueService;

        public ItemVendaEstoqueAppService(IItemVendaEstoqueService itemVendaEstoqueService)
            : base(itemVendaEstoqueService)
        {
            _itemVendaEstoqueService = itemVendaEstoqueService;
        } 



    }
}
