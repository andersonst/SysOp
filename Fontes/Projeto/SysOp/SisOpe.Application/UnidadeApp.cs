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
    public class UnidadeApp : AppServiceBase<Unidade>, IUnidadeAppService
    {
        private readonly IUnidadeService _unidadeService;

        public UnidadeApp(IUnidadeService unidadeService)
            :base(unidadeService)
        {
            _unidadeService = unidadeService;
        }
    }
}