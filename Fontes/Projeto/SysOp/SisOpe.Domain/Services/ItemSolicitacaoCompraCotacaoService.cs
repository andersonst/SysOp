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
    public class ItemSolicitacaoCompraCotacaoService : ServiceBase<ItemSolicitacaoCompraCotacao>, IItemSolicitacaoCompraCotacaoService
    {
        private readonly IItemSolicitacaoCompraCotacaoRepository _itemSolicitacaoCompraCotacaoRepository;

        public ItemSolicitacaoCompraCotacaoService(IItemSolicitacaoCompraCotacaoRepository itemSolicitacaoCompraCotacaoRepository)
            :base(itemSolicitacaoCompraCotacaoRepository)
        {
            _itemSolicitacaoCompraCotacaoRepository = itemSolicitacaoCompraCotacaoRepository;
        }
    }
}
