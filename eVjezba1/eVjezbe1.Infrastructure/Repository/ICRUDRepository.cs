using eVjezba1.Core;
using eVjezbe1.Infrastructure.DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.Repository
{
    public interface ICRUDRepository<TEntity> 
        where TEntity : class
    {
        public List<TEntity> GetAll();
    }
}
