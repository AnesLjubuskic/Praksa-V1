using eVjezbe1.Infrastructure.RepositoryUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.UoW
{
    public interface IUnitOfWork
    {
        IUserRepository _userRepository { get; set; }
        public void Start();
        public void Commit();
        public void Rollback();
    }
}
