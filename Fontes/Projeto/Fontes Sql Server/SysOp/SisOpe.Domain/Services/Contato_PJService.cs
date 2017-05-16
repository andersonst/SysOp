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
    public class Contato_PJService : ServiceBase<Contato_PJ>, IContato_PJService
    {
        private readonly IContato_PJRepository _contato_PJRepository;

        public Contato_PJService(IContato_PJRepository contato_PJRepositor)
            : base(contato_PJRepositor)
        {
            _contato_PJRepository = contato_PJRepositor;
        }
    }
}
