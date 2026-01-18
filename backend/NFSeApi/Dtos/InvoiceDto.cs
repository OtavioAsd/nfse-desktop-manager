<<<<<<< HEAD
﻿using System;

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
=======
﻿namespace NFSeApi.Dtos
{
    public class InvoiceDto
    {
>>>>>>> d76cd1cece0b8c9694ba8ac96b4951feff5afa3b
    }
}
