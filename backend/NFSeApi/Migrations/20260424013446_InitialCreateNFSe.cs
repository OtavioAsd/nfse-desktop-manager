using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NFSeApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateNFSe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NFSes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NFSeNumber = table.Column<string>(type: "text", nullable: false),
                    AccessKey = table.Column<string>(type: "text", nullable: true),
                    ServiceRecipientName = table.Column<string>(type: "text", nullable: false),
                    ServiceRecipientCNPJ = table.Column<string>(type: "text", nullable: false),
                    ServiceProviderName = table.Column<string>(type: "text", nullable: false),
                    ServiceProviderCNPJ = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Pdfpath = table.Column<string>(type: "text", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: false),
                    Validate = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFSes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NFSes");
        }
    }
}
