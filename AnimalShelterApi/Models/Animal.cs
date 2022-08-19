using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    [Range(0, 800, ErrorMessage = "Age must be between 0 and 800.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
  }
}