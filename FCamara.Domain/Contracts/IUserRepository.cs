using FCamara.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCamara.Domain.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        User Authenticate(string username, string password);
    }
}
