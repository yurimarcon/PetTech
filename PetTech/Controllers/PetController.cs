using Microsoft.AspNetCore.Mvc;
using PetTech.Data;
using PetTech.Entities;

namespace PetTech.Controllers;

[ApiController]
[Route("[controller]")]
public class PetController : ControllerBase
{
    private readonly ILogger<PetController> _logger;
    private readonly AppDbContext _context;
    
    public PetController(ILogger<PetController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetPet")]
    public IEnumerable<Pet> Get()
    {
        return _context.Pets.ToList();
    }

    [HttpPost(Name="PostPet")]
    public ActionResult<Pet> Post(Pet pet)
    {
        _context.Add(pet);
        _context.SaveChanges();
        return Ok(pet);
    }
}
