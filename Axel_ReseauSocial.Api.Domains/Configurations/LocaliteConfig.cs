using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Globalization;

namespace Axel_ReseauSocial.Api.Domains.Configurations
{
    internal class LocaliteConfig : IEntityTypeConfiguration<Localite>
    {
        public void Configure(EntityTypeBuilder<Localite> builder)
        {
            builder.ToTable("Localite");

            builder.HasKey(l => l.IdLocalite);
            builder.Property(l => l.IdLocalite).HasDefaultValueSql("NEWSEQUENTIALID()");
            builder.Property(l => l.Ville)
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();
        }
    }
}
