using Microsoft.EntityFrameworkCore;

using CinemaServer.Models;

namespace CinemaServer.Data
{
    public class CinemaContext : DbContext
    {
        public DbSet<FilmShow> FilmShows { get; set; }

        public DbSet<FilmOrder> FilmOrders { get; set; }

        public CinemaContext(DbContextOptions<CinemaContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
