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
    public class TelefoneApp : AppServiceBase<Telefone>, ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;

        public TelefoneApp(ITelefoneService telefoneService)
            :base(telefoneService)
        {
            _telefoneService = telefoneService;
        }
    }
}
