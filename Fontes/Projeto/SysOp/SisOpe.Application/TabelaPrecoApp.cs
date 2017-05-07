﻿using SisOpe.Domain.Entidades;
using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application
{
    public class TabelaPrecoApp : AppServiceBase<TabelaPreco>, ITabelaPrecoAppService
    {
        private readonly ITabelaPrecoService _tabelaPrecoService;

        public TabelaPrecoApp(ITabelaPrecoService tabelaPrecoService)
            :base(tabelaPrecoService)
        {
            _tabelaPrecoService = tabelaPrecoService;
        }
    }
}
