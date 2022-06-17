using Infrastructure.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Implementations
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepositor)
        {
            _usersRepository = usersRepositor;
        }

        public List<User> GetUsers()
        {
            return _usersRepository.GetUsers();
        }
        public void AddUser(User newUser)
        {
            _usersRepository.AddUser(newUser);
        }
    }
}
