using eVjezbe1.Infrastructure.DBAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.Repository
{
    public abstract class CRUDRepository<TEntity> :
        ICRUDRepository<TEntity> where TEntity : class
    {
        protected  ApplicationDB _dbContext { get; set; }
        protected  DbSet<TEntity> _dbSet { get; set; }
        public  CRUDRepository(ApplicationDB dbContext)
        {
            _dbContext= dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
