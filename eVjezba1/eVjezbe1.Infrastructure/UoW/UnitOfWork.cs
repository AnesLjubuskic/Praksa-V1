using eVjezbe1.Infrastructure.DBAccess;
using eVjezbe1.Infrastructure.RepositoryUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository _userRepository { get; set; }
        protected ApplicationDB _dbContext;
        public UnitOfWork(ApplicationDB dbContext,IUserRepository userRepository)
        {
            _dbContext = dbContext;
            _userRepository = userRepository;
        }


        public void Commit()
        {
            _dbContext.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _dbContext.Database.RollbackTransaction();
        }

        public void Start()
        {
            _dbContext.Database.BeginTransaction();
        }
    }
}
