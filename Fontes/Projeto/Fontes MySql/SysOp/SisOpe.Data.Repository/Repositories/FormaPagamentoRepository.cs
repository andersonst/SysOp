﻿using SisOpe.Data.Contexto;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Data.Repository.Repositories
{
    public class FormaPagamentoRepository : RepositoryBase<FormaPagamento>, IFormaPagamentoRepository
    {
        private readonly SysOpContext _db;
        public FormaPagamentoRepository(SysOpContext db)
           : base(db)
        {
            _db = db;
        }
    }
}
