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
    public class FuncionarioApp : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioApp(IFuncionarioService funcionarioService)
            : base(funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
    }
}
