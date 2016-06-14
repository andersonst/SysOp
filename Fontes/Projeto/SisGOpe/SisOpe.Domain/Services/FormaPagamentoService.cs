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
    public class FormaPagamentoservice : ServiceBase<FormaPagamento>, IFormaPagamentoService
    {
        private readonly IFormaPagamentoRepository _formaPagamentoRepository;
        public FormaPagamentoservice(IFormaPagamentoRepository formaPagamentoRepository)
            : base(formaPagamentoRepository)
        {
            _formaPagamentoRepository = formaPagamentoRepository;
        }
    }
}
