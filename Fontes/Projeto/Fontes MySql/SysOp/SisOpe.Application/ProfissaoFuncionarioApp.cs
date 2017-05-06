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
    public class ProfissaoFuncionarioApp : AppServiceBase<ProfissaoFuncionario>, IProfissaoFuncionarioAppService
    {
        private readonly IProfissaoFuncionarioService _profissaoFuncionarioService;

        public ProfissaoFuncionarioApp(IProfissaoFuncionarioService profissaoFuncionarioService)
            :base(profissaoFuncionarioService)
        {
            _profissaoFuncionarioService = profissaoFuncionarioService;
        }
    }
}
