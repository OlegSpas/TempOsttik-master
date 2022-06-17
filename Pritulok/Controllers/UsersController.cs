using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Pritulok.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public UsersController (IUsersService usersService)
        {
            _usersService = usersService;
        } 

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _usersService.GetUsers().ToArray();
        }
        [HttpPost]
        public void AddUser(User newUser)
        {
            _usersService.AddUser(newUser);
        }
    }
}
