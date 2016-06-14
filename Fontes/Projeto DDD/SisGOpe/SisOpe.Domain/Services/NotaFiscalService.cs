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
    public class NotaFiscalService : ServiceBase<NotaFiscal>, INotaFiscalService
    {
        private readonly INotaFiscalRepository _notaFiscalRepository;

        public NotaFiscalService(INotaFiscalRepository notaFiscalRepository)
            : base(notaFiscalRepository)

        {
            _notaFiscalRepository = notaFiscalRepository;
        }
    }
}
