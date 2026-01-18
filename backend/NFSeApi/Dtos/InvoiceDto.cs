using System;

namespace NFSeApi.Dtos
{
    public class InvoiceDto
    {
        // Identificação da NF
        public string NFSeNumber { get; set; } = string.Empty;

        // Tomador do serviço
        public string CompanyName { get; set; } = string.Empty;
        public string CNPJ { get; set; } = string.Empty;

        // Dados fiscais
        public DateTime IssueDate { get; set; }
        public decimal Price { get; set; }

        // Documento
        public string PdfPath { get; set; } = string.Empty;
    }
}
