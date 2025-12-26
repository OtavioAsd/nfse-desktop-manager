# Invoice Field Ownership

| Field        | Owner            |
|-------------|------------------|
| NFSeNumber  | API              |
| CNPJ        | API              |
| CompanyName | API / USER       |
| IssueDate   | SYSTEM (required)|
| Price       | SYSTEM (required if known) |
| PdfPath     | SYSTEM           |
| Comment     | USER             |
| Validation  | SYSTEM / API     |
| Source      | SYSTEM (API \| MANUAL) |
| CreatedAt   | SYSTEM           |

# Overwrite Rules

## API Sync
- API sync **never overwrites**:
  - Comment
  - Manual invoices

## Manual Invoices
- Never sent to API

## API Invoices
- Status may update via API
- User data never changes

# Required Fields

- IssueDate
- PdfPath
- Source

# Optional Fields

- NFSeNumber
- CNPJ
- Price (manual case)
