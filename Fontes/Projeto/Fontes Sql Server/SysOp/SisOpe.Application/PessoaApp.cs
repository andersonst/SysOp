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
    public class PessoaApp : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApp(IPessoaService pessoaService)
            : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }
    }
}
