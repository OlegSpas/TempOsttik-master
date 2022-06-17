using Infrastructure.Repositories;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Implementations
{
    public class PetsService: IPetsService
    {
        private readonly IPetsRepository _petsRepository;

        public PetsService(IPetsRepository petsRepositor)
        {
            _petsRepository = petsRepositor;
        }

        public List<Pet> GetPets()
        {
            return _petsRepository.GetPets();
        }
        public void AddPet(Pet newPet)
        {
            _petsRepository.AddPet(newPet);
        }
    }
}
