﻿using SisOpe.Application.Interfaces;
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
    public class FormaPagamentoservice : AppServiceBase<FormaPagamento>, IFormaPagamentoAppService
    {
        private readonly IFormaPagamentoService _formaPagamentoService;
        public FormaPagamentoservice(IFormaPagamentoService formaPagamentoService)
            : base(formaPagamentoService)
        {
            _formaPagamentoService = formaPagamentoService;
        }
    }
}
