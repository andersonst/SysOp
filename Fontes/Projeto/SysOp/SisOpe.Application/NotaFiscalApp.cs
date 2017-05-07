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
    public class NotaFiscalApp : AppServiceBase<NotaFiscal>, INotaFiscalAppService
    {
        private readonly INotaFiscalService _notaFiscalService;

        public NotaFiscalApp(INotaFiscalService notaFiscalService)
            : base(notaFiscalService)

        {
            _notaFiscalService = notaFiscalService;
        }
    }
}
