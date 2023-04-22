using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, AnimalName = "Cosmo", AnimalType = "Dog", AnimalBreed = "Gold Retriever", Age = 3, City = "Portland" },
          new Animal { AnimalId = 2, AnimalName = "Pepper", AnimalType = "Dog", AnimalBreed = "Catahoula", Age = 5, City = "Portland" },
          new Animal { AnimalId = 3, AnimalName = "Scales", AnimalType = "Snake", AnimalBreed = "Garter", Age = 1, City = "Fairbanks" },
          new Animal { AnimalId = 4, AnimalName = "Blinky", AnimalType = "Fish", AnimalBreed = "Goldfish", Age = 12, City = "Faibanks" },
          new Animal { AnimalId = 5, AnimalName = "Sonny", AnimalType = "Dog", AnimalBreed = "Chocolate Lab", Age = 11, City = "Portland" }
        );
    }
  }
}