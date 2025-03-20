using Microsoft.EntityFrameworkCore;
using ValorantApi.Models;

namespace ValorantApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Jogador> Jogadores { get; set; }
    }
}
