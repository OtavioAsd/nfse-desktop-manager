using Microsoft.EntityFrameworkCore;
using NFSeApi.InvoiceModels;

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

