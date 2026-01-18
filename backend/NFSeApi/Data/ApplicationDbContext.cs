using Microsoft.EntityFrameworkCore;
using NFSeApi.Entities;

namespace NFSeApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NFSe> NFSes { get; set; }
    }
}

