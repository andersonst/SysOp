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
    public class ProfissaoAppService : AppServiceBase<Profissao>, IProfissaoAppService
    {
        private readonly IProfissaoService _profissaoService;

        public ProfissaoAppService(IProfissaoService profissaoService)
            : base(profissaoService)
        {
            _profissaoService = profissaoService;
        }
    }
}
