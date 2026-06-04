using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NFSeApi.Entities;

namespace NFSeApi.Data.Configurations
{

    public class NFSeConfiguration : IEntityTypeConfiguration<NFSe>
        {
        public void Configure(EntityTypeBuilder<NFSe> builder)
        {
            builder.ToTable("NFSes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NFSeNumber)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.ServiceRecipientName)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.ServiceRecipientCNPJ)
                .IsRequired()
                .HasMaxLength(14)
                .IsFixedLength();
            builder.Property(x => x.ServiceProviderName)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(x => x.ServiceProviderCNPJ)
                .IsRequired()
                .HasMaxLength(14)
                .IsFixedLength();
            builder.Property(x => x.Competence)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.PdfPath)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.Source)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.AccessKey)
                .HasMaxLength(100);
            builder.Property(x => x.XmlPath)
                .HasMaxLength(500);
            builder.Property(x => x.ValidationType)
                .HasMaxLength(100);
            builder.Property(x => x.ValidationNotes)
                .HasMaxLength(1000);
            builder.Property(x => x.Price)
                .HasPrecision(18, 2);
            builder.Property(x => x.IssuedDate)
                .IsRequired();
            builder.Property(x => x.CreatedAt)
                .IsRequired();
            builder.Property(x => x.UpdatedAt)
                .IsRequired(false);
            builder.HasIndex(x => x.NFSeNumber)
                .HasDatabaseName("IX_NFSe_Number");
            builder.HasIndex(x => x.IssuedDate)
                .HasDatabaseName("IX_NFSe_IssuedDate");
            builder.HasIndex(x => x.ServiceProviderCNPJ)
                .HasDatabaseName("IX_NFSe_ProviderCNPJ");
            builder.HasIndex(x => x.ServiceRecipientCNPJ)
                .HasDatabaseName("IX_NFSe_RecipientCNPJ");
            builder.HasIndex(x => x.Competence)
                .HasDatabaseName("IX_NFSe_Competence");
            builder.HasIndex(x => new { x.IssuedDate, x.Price })
                .HasDatabaseName("IX_NFSe_IssuedDate_Price");
        }
    }
}