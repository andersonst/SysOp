using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class Ecf_FuncionarioApp : AppServiceBase<Ecf_Funcionario>, IEcf_FuncionarioAppService
    {
        private readonly IEcf_FuncionarioService _ecf_FuncionarioService;

        public Ecf_FuncionarioApp(IEcf_FuncionarioService ecf_FuncionarioService)
            : base(ecf_FuncionarioService)
        {
            _ecf_FuncionarioService = ecf_FuncionarioService;
        }
    }
}
