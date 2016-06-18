using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class AcessoAppService : AppServiceBase<Acesso>, IAcessoAppService
    {
        private readonly IAcessoService _acessoService;

        public AcessoAppService(IAcessoService acessoService) : base(acessoService)
        {
            _acessoService = acessoService;
        }
    }
}
