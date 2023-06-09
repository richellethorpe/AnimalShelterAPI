using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

   
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      List<Animal> PagedResponse = await _db.Animals
          .Skip((validFilter.PageNumber -1) * validFilter.PageSize)
          .Take(validFilter.PageSize)
          .ToListAsync();
      return Ok(new PagedResponse<List<Animal>>(PagedResponse, validFilter.PageNumber, validFilter.PageSize));
    }

   
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAnimal(int id)
    {
            var animal = await _db.Animals.Where(animal => animal.AnimalId == id).FirstOrDefaultAsync();

            // if (animal == null)
            // {
            //     Response<Animal> animal = new Response<Animal>();
            //     response.Succeeded = false;
            //     response.Message = "Animal was not found in the database";
            //     return NotFound(response);
            // }

            return Ok(new Response<Animal>(animal));
    }

    [HttpPost]
    public async Task<ActionResult<Animal>> Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAnimal(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

     [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      Animal animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}