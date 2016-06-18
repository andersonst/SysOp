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
    public class AcessoUsuarioService : ServiceBase<AcessoUsuario>, IAcessoUsuarioService
    {
        private readonly IAcessoUsuarioRepository _acessoUsuarioRepository;

        public AcessoUsuarioService(IAcessoUsuarioRepository acessoUsuarioRepository)
            : base(acessoUsuarioRepository)
        {
            _acessoUsuarioRepository = acessoUsuarioRepository;
        }
    }
}
