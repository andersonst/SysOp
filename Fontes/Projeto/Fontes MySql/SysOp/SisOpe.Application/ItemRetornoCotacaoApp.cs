using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class ItemRetornoCotacaoApp : AppServiceBase<ItemRetornoCotacao>, IItemRetornoCotacaoAppService
    {
        private readonly IItemRetornoCotacaoService _itemRetornoCotacaoService;

        public ItemRetornoCotacaoApp(IItemRetornoCotacaoService itemRetornoCotacaoService)
            : base(itemRetornoCotacaoService)
        {
            _itemRetornoCotacaoService = itemRetornoCotacaoService;
        }
    }
}
