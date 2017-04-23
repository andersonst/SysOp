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
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
            : base(pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
    }
}
