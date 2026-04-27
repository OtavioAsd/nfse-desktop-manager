using Microsoft.EntityFrameworkCore;
using NFSeApi.Data;
using NFSeApi.Dtos;
using NFSeApi.Entities;

namespace NFSeApi.Services
{
    public class NFSeService
    {
        private readonly ApplicationDbContext _context;

        public NFSeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<NFSe>> GetAllAsync()
        {
            return await _context.NFSes.ToListAsync();
        }

        public async Task<NFSe> CreateAsync(InvoiceDto dto)
        {
            var nfse = new NFSe
            {
                NFSeNumber = dto.NFSeNumber,
                ServiceRecipientName = dto.ServiceRecipientName,
                ServiceRecipientCNPJ = dto.ServiceRecipientCNPJ,
                ServiceProviderName = dto.ServiceProviderName,
                ServiceProviderCNPJ = dto.ServiceProviderCNPJ,
                IssuedDate = DateTime.SpecifyKind(dto.IssueDate, DateTimeKind.Utc),
                Price = dto.Price,
                Pdfpath = dto.PdfPath,
                Source = "Manual",
                Validate = true
            };

            _context.NFSes.Add(nfse);
            await _context.SaveChangesAsync();

            return nfse;
        }
    }
}