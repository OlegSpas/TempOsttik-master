using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Implementations
{
    public class PetsRepository: IPetsRepository
    {
        private readonly PritulokDBContext _dBContext;

        public PetsRepository(PritulokDBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public List<Pet> GetPets()
        {
            return _dBContext.Pets.Include(e => e.Images).ToList();
        }
        public void AddPet(Pet newPet)
        {
            var Images = newPet.Images;
            _dBContext.Pets.Add(newPet);
            _dBContext.SaveChanges();
        }
    }
}
