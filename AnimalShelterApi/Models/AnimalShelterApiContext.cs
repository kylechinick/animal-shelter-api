using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Pet>()
        .HasData(
            new Pet { PetId = 1, Name = "Al", Species = "Dog", Age = 7, Gender = "Male" },
            new Pet { PetId = 2, Name = "Bobbi", Species = "Panda", Age = 10, Gender = "Unknown" },
            new Pet { PetId = 3, Name = "Charlie", Species = "Cat", Age = 2, Gender = "Male" },
            new Pet { PetId = 4, Name = "La Rata Alta", Species = "Chihuahua", Age = 4, Gender = "Female" },
            new Pet { PetId = 5, Name = "Buddy", Species = "Narwhal", Age = 22, Gender = "Male" }
        );
    }
    public DbSet<Pet> Pets { get; set; }
  }
}