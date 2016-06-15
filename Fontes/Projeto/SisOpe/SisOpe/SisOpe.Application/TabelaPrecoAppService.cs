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
    public class TabelaPrecoAppService : AppServiceBase<TabelaPreco>, ITabelaPrecoAppService
    {
        private readonly ITabelaPrecoService _tabelaPrecoService;

        public TabelaPrecoAppService(ITabelaPrecoService tabelaPrecoService)
            :base(tabelaPrecoService)
        {
            _tabelaPrecoService = tabelaPrecoService;
        }
    }
}
