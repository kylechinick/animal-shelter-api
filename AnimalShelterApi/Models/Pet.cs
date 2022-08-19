using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Pet
  {
    public int PetId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}