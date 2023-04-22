using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    public string AnimalName { get; set; }
 
    public string Type { get; set; }
 
    public string Country { get; set; }

  }
}