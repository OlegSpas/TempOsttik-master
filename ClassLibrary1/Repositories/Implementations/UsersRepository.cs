using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class UsersRepository : IUsersRepository
    {
        private readonly PritulokDBContext _dBContext;

        public UsersRepository(PritulokDBContext dbContext)
        {
            _dBContext = dbContext;
        }

        public List<User> GetUsers()
        {
            return _dBContext.Users.ToList();
        }
    }
}
