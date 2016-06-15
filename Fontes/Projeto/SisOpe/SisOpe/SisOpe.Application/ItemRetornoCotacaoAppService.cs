using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class ItemRetornoCotacaoAppService : AppServiceBase<ItemRetornoCotacao>, IItemRetornoCotacaoAppService
    {
        private readonly IItemRetornoCotacaoService _itemRetornoCotacaoService;

        public ItemRetornoCotacaoAppService(IItemRetornoCotacaoService itemRetornoCotacaoService)
            : base(itemRetornoCotacaoService)
        {
            _itemRetornoCotacaoService = itemRetornoCotacaoService;
        }
    }
}
