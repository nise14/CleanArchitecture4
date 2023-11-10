using Contoso.Entities;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Repository.EFCore;

public class ContosoDBContext : DbContext
{
    public ContosoDBContext(DbContextOptions<ContosoDBContext> options) : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Favorite> Favorites { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UsersVideo> UsersVideos { get; set; }
    public DbSet<Video> Videos { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     base.OnConfiguring(optionsBuilder);

    //     optionsBuilder.UseSqlServer(@"data source=.;Database=ContosoDB;Trusted_Connection=true;TrustServerCertificate=true");
    // }
}
