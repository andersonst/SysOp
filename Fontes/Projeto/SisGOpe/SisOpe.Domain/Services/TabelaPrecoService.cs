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
    public class TabelaPrecoService : ServiceBase<TabelaPreco>, ITabelaPrecoService
    {
        private readonly ITabelaPrecoRepository _tabelaPrecoRepository;

        public TabelaPrecoService(ITabelaPrecoRepository tabelaPrecoRepository)
            :base(tabelaPrecoRepository)
        {
            _tabelaPrecoRepository = tabelaPrecoRepository;
        }
    }
}
