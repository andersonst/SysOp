using SisOpe.Application.Interfaces;
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
    public class CotacaoApp : AppServiceBase<Cotacao>, ICotacaoAppService
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoApp(ICotacaoService cotacaoService) : base(cotacaoService)

        {
            _cotacaoService = cotacaoService;
        }
    }
}
