using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void ExecuteProcedure(string sql, params SqlParameter[] parameters);
        List<TEntity> ExecuteToListProcedure(string sql, params SqlParameter[] parameters);
        void Dispose();
    }
}
