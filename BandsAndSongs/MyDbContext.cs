using Microsoft.EntityFrameworkCore;

namespace BandsAndSongs;

public class MyDbContext : DbContext
{
    public DbSet<Band> Bands { get; set; }
    public DbSet<Song> Songs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost; port=3306; database=MyDatabaseToCSharp; user=root; password=");
    }
}