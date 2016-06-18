using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class CotacaoAppService : AppServiceBase<Cotacao>, ICotacaoAppService
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoAppService(ICotacaoService cotacaoService) : base(cotacaoService)

        {
            _cotacaoService = cotacaoService;
        }
    }
}
