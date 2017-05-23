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
    public class Ecf_Dav_CabecalhoRepository : RepositoryBase<Ecf_Dav_Cabecalho>, IEcf_Dav_CabecalhoRepository
    {
         private readonly SysOpContext _db;
         public Ecf_Dav_CabecalhoRepository(SysOpContext db)
           : base(db)
        {
            _db = db;
        }
    }
}
