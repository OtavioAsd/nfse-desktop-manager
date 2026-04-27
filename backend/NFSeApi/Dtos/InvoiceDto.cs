using System;

namespace NFSeApi.Dtos
{
    public class InvoiceDto
    {
        public string NFSeNumber { get; set; } = string.Empty;

        public string ServiceRecipientName { get; set; } = string.Empty;
        public string ServiceRecipientCNPJ { get; set; } = string.Empty;

        public string ServiceProviderName { get; set; } = string.Empty;
        public string ServiceProviderCNPJ { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }

        public decimal Price { get; set; }

        public string PdfPath { get; set; } = string.Empty;
    }
}
