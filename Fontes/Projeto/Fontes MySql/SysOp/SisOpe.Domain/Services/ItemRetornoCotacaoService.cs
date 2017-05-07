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
    public class ItemRetornoCotacaoService : ServiceBase<ItemRetornoCotacao>, IItemRetornoCotacaoService
    {
        private readonly IItemRetornoCotacaoRepository _itemRetornoCotacaoRepository;

        public ItemRetornoCotacaoService(IItemRetornoCotacaoRepository itemRetornoCotacaoRepository)
            : base(itemRetornoCotacaoRepository)
        {
            _itemRetornoCotacaoRepository = itemRetornoCotacaoRepository;
        }
    }
}
