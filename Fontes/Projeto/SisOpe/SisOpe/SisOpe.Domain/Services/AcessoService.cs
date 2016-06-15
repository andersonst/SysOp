using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using SisOpe.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Services
{
    public class AcessoService : ServiceBase<Acesso>, IAcessoService
    {
        private readonly IAcessoRepository _acessoRepository;

        public AcessoService(IAcessoRepository acessoRepository) : base(acessoRepository)
        {
            _acessoRepository = acessoRepository;
        }
    }
}
