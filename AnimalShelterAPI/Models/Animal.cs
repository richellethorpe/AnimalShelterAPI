using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    public string AnimalName { get; set; }
 
    public string AnimalType { get; set; }

    public string AnimalBreed { get; set; }

    public int Age { get; set; }

    public string City { get; set; }

  }
}