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
    public class SolicitacaoCompraService : ServiceBase<SolicitacaoCompra>, ISolicitacaoCompraService
    {
        private readonly ISolicitacaoCompraRepository _solicitacaoCompraRepository;

        public SolicitacaoCompraService(ISolicitacaoCompraRepository solicitacaoCompraRepository)
            :base(solicitacaoCompraRepository)
        {
            _solicitacaoCompraRepository = solicitacaoCompraRepository;
        }
    }
}
