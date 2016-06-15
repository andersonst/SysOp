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
    public class CotacaoService : ServiceBase<Cotacao>, ICotacaoService
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoService(ICotacaoRepository cotacaoRepository) : base(cotacaoRepository)

        {
            _cotacaoRepository = cotacaoRepository;
        }
    }
}
