using Microsoft.EntityFrameworkCore;
using SongAndSuch.Models;

namespace SongAndSuch.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Album> Albums { get; set; }
}