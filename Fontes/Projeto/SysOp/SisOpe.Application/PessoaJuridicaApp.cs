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
    public class PessoaJuridicaApp : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public PessoaJuridicaApp(IPessoaJuridicaService pessoaJuridicaService)
            :base(pessoaJuridicaService)
        {
            _pessoaJuridicaService = pessoaJuridicaService;
        }
    }
}
