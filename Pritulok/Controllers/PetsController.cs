using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Collections.Generic;

namespace Pritulok.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetsService _petsService;
        public PetsController(IPetsService petsService)
        {
            _petsService = petsService;
        }

        [HttpGet]
        public IEnumerable<Pet> GetAll()
        {
            return _petsService.GetPets().ToArray();
        }
        [HttpPost]
        public void AddPet(Pet newPet)
        {
            _petsService.AddPet(newPet);
        }
    }
}
