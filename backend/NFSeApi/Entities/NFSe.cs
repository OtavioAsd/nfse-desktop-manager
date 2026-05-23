using System;

namespace NFSeApi.Entities
{
    public class NFSe
    {
        public Guid Id { get; set; }

        public string NFSeNumber { get; set; } = string.Empty;
        public string? AccessKey { get; set; }

        public string ServiceRecipientName { get; set; } = string.Empty;
        public string ServiceRecipientCNPJ { get; set; } = string.Empty;

        public string ServiceProviderName { get; set; } = string.Empty;
        public string ServiceProviderCNPJ { get; set; } = string.Empty;
        public string Competence { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public DateTime IssuedDate { get; set; }

        public string PdfPath { get; set; } = string.Empty;
        public string? XmlPath { get; set; }

        public string Source { get; set; } = string.Empty;
        public bool IsValidated { get; set; } = false;
        public string? ValidationType { get; set; }
        public string? ValidationNotes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

    }
}
