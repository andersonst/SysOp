using SisOpe.Data.Contexto;
using SisOpe.Domain.Entidades;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Data.Repository.Repositories
{
    public class Ecf_OperadorRepository : RepositoryBase<Ecf_Operador>, IEcf_OperadorRepository
    {
        private readonly SysOpContext _db;
        public Ecf_OperadorRepository(SysOpContext db)
           : base(db)
        {
            _db = db;
        }
    }
}
