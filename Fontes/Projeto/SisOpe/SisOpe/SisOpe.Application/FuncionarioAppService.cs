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
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioAppService(IFuncionarioService funcionarioService)
            : base(funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
    }
}
