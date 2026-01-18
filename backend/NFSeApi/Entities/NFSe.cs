using System;

namespace NFSeApi.Entities
{
    public class NFSe
    {
        public Guid Id { get; set; }

        public string NFSeNumber { get; set; } = string.Empty;
        public string? AccessKey { get; set; }

        public string ServiceRecipientName {  get; set; } = string.Empty;
        public string ServiceRecipientCNPJ { get; set; } = string.Empty;

        public string ServiceProviderName { get; set; } = string.Empty;
        public string ServiceProviderCNPJ { get; set; } = string.Empty;

        public decimal Price {  get; set; }
        public DateTime IssuedDate { get; set; }

        public string Pdfpath { get; set; } = string.Empty;

        public string Source {  get; set; } = string.Empty;
        public bool Validate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
