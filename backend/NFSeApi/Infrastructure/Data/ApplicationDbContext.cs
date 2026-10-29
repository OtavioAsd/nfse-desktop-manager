using Microsoft.EntityFrameworkCore;
using NFSeApi.Domain.Entities;

namespace NFSeApi.Infrastructure.Data
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

