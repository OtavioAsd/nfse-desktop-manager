using Microsoft.EntityFrameworkCore;
using NFSeApi.Models;

namespace NFSeApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<InvoiceModels> Invoices { get; set; }
    }
}
