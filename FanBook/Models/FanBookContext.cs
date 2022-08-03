using Microsoft.EntityFrameworkCore;

namespace FanBook.Models
{
  public class FanBookContext : DbContext
  {
    public DbSet<Band> Bands { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<BandGenre> BandGenre { get; set; }
    public DbSet<BandMember> BandMember { get; set; }

    public FanBookContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}