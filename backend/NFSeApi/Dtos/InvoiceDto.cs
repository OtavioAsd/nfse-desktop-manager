using System;

namespace NFSeApi.Dtos
{
    public class InvoiceDto
    {
        public string NFSeNumber { get; set; }

        public string ServiceRecipientName { get; set; }
        public string ServiceRecipientCNPJ { get; set; }

        public string ServiceProviderName { get; set; }
        public string ServiceProviderCNPJ { get; set; }

        public DateTime IssueDate { get; set; }
        public decimal Price { get; set; }

        public string PdfPath { get; set; }
    }
}
