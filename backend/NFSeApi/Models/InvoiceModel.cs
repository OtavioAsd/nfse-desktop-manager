using System;

public class InvoiceModels

{
	public string NFSeNumber { get; set; }
	public string CompanyName { get; set; }
	public string CNPJ { get; set; }
	public DateTime IssueDate { get; set; }
	public DateTime CreatedAt { get; set; }
	public Decimal Price { get; set; }
	public string Validation { get; set; }

}
