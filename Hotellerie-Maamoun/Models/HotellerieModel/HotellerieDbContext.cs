using Microsoft.EntityFrameworkCore;

namespace Hotellerie_Maamoun.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Appreciation> Appreciations { get; set; }
    }
}
