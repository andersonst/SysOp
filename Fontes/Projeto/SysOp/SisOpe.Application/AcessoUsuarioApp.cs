using SisOpe.Application.Interfaces;
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
    public class AcessoUsuarioApp : AppServiceBase<AcessoUsuario>, IAcessoUsuarioAppService
    {
        private readonly IAcessoUsuarioService _acessoUsuarioService;

        public AcessoUsuarioApp(IAcessoUsuarioService acessoUsuarioService)
            : base(acessoUsuarioService)
        {
            _acessoUsuarioService = acessoUsuarioService;
        }
    }
}
