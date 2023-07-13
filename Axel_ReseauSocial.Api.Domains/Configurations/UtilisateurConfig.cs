using Axel_ReseauSocial.Api.Domains.Tools;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Configurations
{
    internal class UtilisateurConfig : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable("Utilisateur");

            builder.HasKey(u => u.IdUtilisateur);

            builder.Property(u => u.IdUtilisateur)
                .HasDefaultValueSql("NEWSEQUENTIALID()");

            builder.Property(u => u.Nom)
                .IsRequired()
                .HasColumnType("NVARCHAR(75)");

            builder.Property(u => u.Prenom)
                .IsRequired()
                .HasColumnType("NVARCHAR(75)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnType("NVARCHAR(384)");

            builder.Property(u => u.Passwd)
                .IsRequired()
                .HasColumnType("BINARY(64)")
                .HasConversion(new ValueConverter<string?, byte[]>(v => v.Hash(), v => null));

            builder.HasOne(u => u.Localite)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(u => u.Role)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
