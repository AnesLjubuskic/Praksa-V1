using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        public void Start();
        public void Commit();
        public void Rollback();
    }
}
