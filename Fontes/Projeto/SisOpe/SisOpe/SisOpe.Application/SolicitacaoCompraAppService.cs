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
    public class SolicitacaoCompraAppService : AppServiceBase<SolicitacaoCompra>, ISolicitacaoCompraAppService
    {
        private readonly ISolicitacaoCompraService _solicitacaoCompraService;

        public SolicitacaoCompraAppService(ISolicitacaoCompraService solicitacaoCompraService)
            :base(solicitacaoCompraService)
        {
            _solicitacaoCompraService = solicitacaoCompraService;
        }
    }
}
