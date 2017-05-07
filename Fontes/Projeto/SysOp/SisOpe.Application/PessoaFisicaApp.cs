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
    public class PessoaFisicaApp : AppServiceBase<PessoaFisica>, IPessoaFisicaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaFisicaApp(IPessoaFisicaService pessoaFisicaService)
            : base(pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }
    }
}
