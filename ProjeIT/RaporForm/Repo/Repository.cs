    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Internal;
    using RaporForm.Models.RaporFormDB;
namespace RaporForm.Repo
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private ReportFormContext rpContext;
        private DbSet<T> dbSet;

        public Repository()
        {
            rpContext = new ReportFormContext(new DbContextOptions<ReportFormContext>());
            dbSet = rpContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Update(T obj)
        {
            rpContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object Id)
        {
            T getObjectById = dbSet.Find(Id);
            dbSet.Remove(getObjectById);
        }

        public void Save()
        {
            rpContext.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.rpContext != null)
                {
                    this.rpContext.Dispose();
                    this.rpContext = null;
                }
            }
        }
    }
}
