﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configuration
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasKey(e => e.DocumentTypeId).HasName("PK__Document__DBA390E12BCFE2F5");

            builder.Property(e => e.Abbreviation)
                 .HasMaxLength(5)
                 .IsUnicode(false);
            builder.Property(e => e.Code)
                 .HasMaxLength(10)
                 .IsUnicode(false);
            builder.Property(e => e.Name)
                 .HasMaxLength(255)
                 .IsUnicode(false);
        }
    }
}
