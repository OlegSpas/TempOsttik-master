﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IPetsRepository
    {
        public List<Pet> GetPets();
        public void AddPet(Pet newPet);
    }
}
