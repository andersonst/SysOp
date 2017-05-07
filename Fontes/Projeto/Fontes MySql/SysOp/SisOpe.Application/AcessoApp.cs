using SisOpe.Application.Interfaces;
using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using SisOpe.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class AcessoApp : AppServiceBase<Acesso>, IAcessoAppService
    {
        private readonly IAcessoService _acessoService;

        public AcessoApp(IAcessoService acessoService) : base(acessoService)
        {
            _acessoService = acessoService;
        }
    }
}
