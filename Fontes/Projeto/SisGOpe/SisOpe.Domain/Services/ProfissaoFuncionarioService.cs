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
    public class ProfissaoFuncionarioService : ServiceBase<ProfissaoFuncionario>, IProfissaoFuncionarioService
    {
        private readonly IProfissaoFuncionarioRepository _profissaoFuncionarioRepository;

        public ProfissaoFuncionarioService(IProfissaoFuncionarioRepository profissaoFuncionarioRepository)
            :base(profissaoFuncionarioRepository)
        {
            _profissaoFuncionarioRepository = profissaoFuncionarioRepository;
        }
    }
}
