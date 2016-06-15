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
