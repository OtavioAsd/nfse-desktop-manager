using System;

namespace NFSeApi.Dtos
{
    public class InvoiceDto
    {
        public string NFSeNumber { get; set; } = string.Empty;
        public string? AccessKey { get; set; }

        public string ServiceRecipientName { get; set; } = string.Empty;
        public string ServiceRecipientCNPJ { get; set; } = string.Empty;

        public string ServiceProviderName { get; set; } = string.Empty;
        public string ServiceProviderCNPJ { get; set; } = string.Empty;

        public DateTime IssueDate { get; set; }
        public string Competence { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public string PdfPath { get; set; } = string.Empty;

        public string Source { get; set; } = "Manual";
        public bool IsValidated { get; set; } = false;
        public string? ValidationType { get; set; }
        public string? ValidationNotes { get; set; }
    }
}
