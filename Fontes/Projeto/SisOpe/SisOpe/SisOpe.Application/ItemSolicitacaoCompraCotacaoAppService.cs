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
    public class ItemSolicitacaoCompraCotacaoAppService : AppServiceBase<ItemSolicitacaoCompraCotacao>, IItemSolicitacaoCompraCotacaoAppService
    {
        private readonly IItemSolicitacaoCompraCotacaoService _itemSolicitacaoCompraCotacaoService;

        public ItemSolicitacaoCompraCotacaoAppService(IItemSolicitacaoCompraCotacaoService itemSolicitacaoCompraCotacaoService)
            :base(itemSolicitacaoCompraCotacaoService)
        {
            _itemSolicitacaoCompraCotacaoService = itemSolicitacaoCompraCotacaoService;
        }
    }
}
