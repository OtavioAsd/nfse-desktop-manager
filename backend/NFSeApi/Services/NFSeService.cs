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

        public async Task<NFSe?> GetByIdAsync(Guid id)
        {
            return await _context.NFSes.FindAsync(id);
        }

        public async Task<NFSe> CreateAsync(InvoiceDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.NFSeNumber))
                throw new ArgumentException("Número da NFS-e é obrigatório");

            if (dto.Price <= 0)
                throw new ArgumentException("Valor da nota deve ser maior que zero");

            if (string.IsNullOrWhiteSpace(dto.Competence))
                throw new ArgumentException("Competência é obrigatória");

            var nfse = new NFSe
            {
                NFSeNumber = dto.NFSeNumber,
                AccessKey = dto.AccessKey,

                ServiceRecipientName = dto.ServiceRecipientName,
                ServiceRecipientCNPJ = dto.ServiceRecipientCNPJ,
                ServiceProviderName = dto.ServiceProviderName,
                ServiceProviderCNPJ = dto.ServiceProviderCNPJ,
                IssuedDate = DateTime.SpecifyKind(dto.IssueDate, DateTimeKind.Utc),
                Price = dto.Price,
                PdfPath = dto.PdfPath,
                XmlPath = null,
                Source = "Manual",
                IsValidated = dto.IsValidated,
                ValidationType = dto.ValidationType,
                ValidationNotes = dto.ValidationNotes,
                CreatedAt = DateTime.UtcNow

            };

            _context.NFSes.Add(nfse);
            await _context.SaveChangesAsync();

            return nfse;
        }
    }
}