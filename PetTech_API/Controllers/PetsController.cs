using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetTech_API.Data;
using PetTech_API.Entities;

namespace PetTech_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetsController : ControllerBase
    {
        private AppDbContext context;

        public PetsController(AppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public ActionResult<List<Pet>> GetPets()
        {
            return Ok(context.Pets.ToList());
        }

        [HttpPost]
        public ActionResult<Pet> PostPet(Pet pet)
        {
            context.Add(pet);
            context.SaveChanges();

            return Ok(pet);
        }
    }
}