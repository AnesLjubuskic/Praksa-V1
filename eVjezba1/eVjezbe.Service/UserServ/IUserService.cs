using eVjezba1.Core;
using eVjezba1.Core.DTO;
using eVjezbe1.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVjezbe.Service.UserServ
{
    public interface IUserService
    {
        public UserDTO GetByUsername(string id);

    }
}
