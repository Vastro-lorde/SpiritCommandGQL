using Microsoft.EntityFrameworkCore;
using SpiritCommandGQL.Models;

namespace SpiritCommandGQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Kernel> Kernels { get; set; }
    }
}
