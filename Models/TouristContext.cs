using Microsoft.EntityFrameworkCore;

namespace TouristSite.Models
{
  // Represents the database context for the application.
  public class TouristContext : DbContext
  {
    public TouristContext(DbContextOptions<TouristContext> options)
        : base(options)
    {
    }

    public DbSet<TownEvent> TownEvents { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Picture> Pictures { get; set; }
    public DbSet<Editor> Editors { get; set; }
  }
}