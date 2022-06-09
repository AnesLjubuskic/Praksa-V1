using eVjezba1.Core.DTO;
using eVjezbe1.Infrastructure.DBAccess;
using eVjezbe1.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eVjezba1.Core;
using eVjezbe1.Infrastructure.RepositoryUser;

namespace eVjezbe.Service.UserServ
{
    public class UserService : IUserService
    {
        IUserRepository _userRep;//zasto interface
        public UserService(IUserRepository userRep)
        {
            _userRep = userRep;
        }
        public UserDTO GetByUsername(string name) { return _userRep.GetByUsername(name); }
    }
}
