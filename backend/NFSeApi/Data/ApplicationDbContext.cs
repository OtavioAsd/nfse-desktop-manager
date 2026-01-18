using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using NFSeApi.Entities;
=======
using NFSeApi.InvoiceModels;
>>>>>>> d76cd1cece0b8c9694ba8ac96b4951feff5afa3b

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

