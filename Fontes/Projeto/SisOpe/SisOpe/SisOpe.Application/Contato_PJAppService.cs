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
    public class Contato_PJAppService : AppServiceBase<Contato_PJ>, IContato_PJAppService
    {
        private readonly IContato_PJService _contato_PJService;

        public Contato_PJAppService(IContato_PJService contato_PJService)
            : base(contato_PJService)
        {
            _contato_PJService = contato_PJService;
        }
    }
}
