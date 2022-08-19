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
      builder.Entity<Animal>()
        .HasData(
            new Animal { AnimalId = 1, Name = "Albert", Species = "Dog", Age = 2, Gender = "Male" },
            new Animal { AnimalId = 2, Name = "Bob", Species = "Panda", Age = 8, Gender = "Unknown" },
            new Animal { AnimalId = 3, Name = "Charlie", Species = "Cat", Age = 8, Gender = "Female" },
            new Animal { AnimalId = 4, Name = "Diana", Species = "Capybara", Age = 64, Gender = "Female" },
            new Animal { AnimalId = 5, Name = "Greggory", Species = "Beholder", Age = 506, Gender = "Unknown" },
            new Animal { AnimalId = 6, Name = "Turbo", Species = "Narwhal", Age = 32, Gender = "Male" },
            new Animal { AnimalId = 7, Name = "Lazer", Species = "Narwhal", Age = 28, Gender = "Male" }
        );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}