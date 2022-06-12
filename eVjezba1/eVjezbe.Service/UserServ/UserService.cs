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
using eVjezbe1.Infrastructure.UoW;

namespace eVjezbe.Service.UserServ
{
    public class UserService : IUserService
    {
        UnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }
        public UserDTO GetByUsername(string name)
        { 
            return _unitOfWork._userRepository.GetByUsername(name); 
        }
    }
}
