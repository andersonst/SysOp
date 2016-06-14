using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Data.Contexto;
using System.Data.SqlClient;

namespace SisOpe.Data.Repository.Repositories
{
    public class RepositoryBase<TEntity>: IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        SysOpContext db = new SysOpContext();

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
           return  db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void ExecuteProcedure(string sql, params SqlParameter[] parameters)
        {
            db.Database.ExecuteSqlCommand(sql, parameters);
        }

        public List<TEntity> ExecuteToListProcedure(string sql, params SqlParameter[] parameters)
        {
            return db.Database.SqlQuery<TEntity>(sql, parameters).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
