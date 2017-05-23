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
    public class Ecf_Dav_DetalheRepository : RepositoryBase<Ecf_Dav_Detalhe>, IEcf_Dav_DetalheRepository
    {
        private readonly SysOpContext _db;
        public Ecf_Dav_DetalheRepository(SysOpContext db)
           : base(db)
        {
            _db = db;
        }
    }
}
