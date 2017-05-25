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
    public class Ecf_FuncionarioService : ServiceBase<Ecf_Funcionario>, IEcf_FuncionarioService
    {
        private readonly IEcf_FuncionarioRepository _ecf_FuncionarioRepository;

        public Ecf_FuncionarioService(IEcf_FuncionarioRepository ecf_FuncionarioRepository)
            : base(ecf_FuncionarioRepository)
        {
            _ecf_FuncionarioRepository = ecf_FuncionarioRepository;
        }
    }
}
