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
    public class PessoaJuridicaAppService : AppServiceBase<PessoaJuridica>, IPessoaJuridicaAppService
    {
        private readonly IPessoaJuridicaService _pessoaJuridicaService;

        public PessoaJuridicaAppService(IPessoaJuridicaService pessoaJuridicaService)
            :base(pessoaJuridicaService)
        {
            _pessoaJuridicaService = pessoaJuridicaService;
        }
    }
}
