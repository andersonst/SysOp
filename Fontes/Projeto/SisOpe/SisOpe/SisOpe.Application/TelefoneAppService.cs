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
    public class TelefoneAppService : AppServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneAppService(ITelefoneService telefoneService)
            :base(telefoneService)
        {
            _telefoneService = telefoneService;
        }
    }
}
