using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IPetsService
    {
        public List<Pet> GetPets();
        public void AddPet(Pet newPet);
    }
}
