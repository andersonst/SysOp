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
    public class TransferenciaEstoqueAppService : AppServiceBase<TransferenciaEstoque>, ITransferenciaEstoqueAppService
    {
        private readonly ITransferenciaEstoqueService _transferenciaEstoqueService;

        public TransferenciaEstoqueAppService(ITransferenciaEstoqueService transferenciaEstoqueService)
            :base(transferenciaEstoqueService)
        {
            _transferenciaEstoqueService = transferenciaEstoqueService;
        }
    }
}
