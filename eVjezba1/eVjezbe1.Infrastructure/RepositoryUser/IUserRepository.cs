using eVjezba1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe1.Infrastructure.RepositoryUser
{
    public interface IUserRepository
    {
        UserDTO GetByUsername(string name);
    }
}
