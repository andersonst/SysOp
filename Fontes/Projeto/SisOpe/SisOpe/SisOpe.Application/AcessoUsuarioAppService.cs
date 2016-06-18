using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;

namespace SisOpe.Application
{
    public class AcessoUsuarioAppService : AppServiceBase<AcessoUsuario>, IAcessoUsuarioAppService
    {
        private readonly IAcessoUsuarioService _acessoUsuarioService;

        public AcessoUsuarioAppService(IAcessoUsuarioService acessoUsuarioService)
            : base(acessoUsuarioService)
        {
            _acessoUsuarioService = acessoUsuarioService;
        }
    }
}
