﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUsersRepository
    {
        public List<User> GetUsers();
        public void AddUser(User newUser);
    }
}
