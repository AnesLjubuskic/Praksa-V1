using eVjezba1.Core;
using eVjezba1.Core.DTO;
using eVjezbe1.Infrastructure.DBAccess;
using eVjezbe1.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.RepositoryUser
{
    public class UserRepository : CRUDRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDB dbContext):base(dbContext)
        {

        }
        public UserDTO GetByUsername(string name)
        {
            var user = _dbSet
                .Where(x => x.UserName.ToLower() == name.ToLower())
                .FirstOrDefault();
            var result=new UserDTO
            {
                UserName = user.UserName,
                FirstName=user.FirstName,
                LastName=user.LastName
            };
            return result;
        }
    }
}
