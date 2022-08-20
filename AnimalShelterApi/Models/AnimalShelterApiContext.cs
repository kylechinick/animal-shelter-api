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
            new Animal { AnimalId = 1, Name = "Albert", Species = "Dog", Age = 2, Gender = "Male", Bio = "Albert likes long walks on the beach. He also likes long walks absolutely everywhere else too." },
            new Animal { AnimalId = 2, Name = "Bob", Species = "Panda", Age = 8, Gender = "Unknown", Bio = "Bob is a very friendly dog but has a strange coat for a dog and is unusually large. Big fan of bamboo though." },
            new Animal { AnimalId = 3, Name = "Charlie", Species = "Cat", Age = 8, Gender = "Female", Bio = "Charlie's hobbies include sleeping, eating, asking for head-pats and promptly walking away when you offer them." },
            new Animal { AnimalId = 4, Name = "Diana", Species = "Capybara", Age = 64, Gender = "Female", Bio = "Wanted by several international policing agencies for arson. Do no allow near matches unsupervised. Likes Cheese Puffs." },
            new Animal { AnimalId = 5, Name = "Greggory", Species = "Beholder", Age = 506, Gender = "Unknown", Bio = "Despite Greggory's unique appearance he makes fast friends and loves playing fetch. Very difficult to sneak up on though so hide-and-seek is probably out of the question." },
            new Animal { AnimalId = 6, Name = "Turbo", Species = "Narwhal", Age = 32, Gender = "Male", Bio = "Pure speed." },
            new Animal { AnimalId = 7, Name = "Lazer", Species = "Narwhal", Age = 28, Gender = "Male", Bio = "Tried out for the Globo Gym Purple Cobras and made the team" }
        );
    }
    public DbSet<Animal> Animals { get; set; }
  }
}