using System;

namespace NFSeApi.Application.Dtos
{
    public class InvoiceDto
    {
        public required string NFSeNumber { get; set; }

        public required string ServiceRecipientName { get; set; }
        public required string ServiceRecipientCNPJ { get; set; }

        public required string ServiceProviderName { get; set; }
        public required string ServiceProviderCNPJ { get; set; }

        public DateTime IssueDate { get; set; }
        public decimal Price { get; set; }

        public required string PdfPath { get; set; }
    }
}
