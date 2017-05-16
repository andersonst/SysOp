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
    public class ProfissaoApp : AppServiceBase<Profissao>, IProfissaoAppService
    {
        private readonly IProfissaoService _profissaoService;

        public ProfissaoApp(IProfissaoService profissaoService)
            : base(profissaoService)
        {
            _profissaoService = profissaoService;
        }
    }
}
