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
    public class PessoaFisicaAppService : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaFisicaAppService(IPessoaFisicaService pessoaFisicaService)
            : base(pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }
    }
}
