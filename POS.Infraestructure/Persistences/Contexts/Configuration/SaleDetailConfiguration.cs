﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configuration
{
    public class SaleDetailConfiguration : IEntityTypeConfiguration<SaleDetail>
    {
        public void Configure(EntityTypeBuilder<SaleDetail> builder)
        {
            builder.HasKey(e => e.SaleDetailId).HasName("PK__SaleDeta__70DB14FEEBC74C4D");

            builder.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Product).WithMany(p => p.SaleDetails)
                 .HasForeignKey(d => d.ProductId)
                 .HasConstraintName("FK__SaleDetai__Produ__6A30C649");

            builder.HasOne(d => d.Sale).WithMany(p => p.SaleDetails)
                 .HasForeignKey(d => d.SaleId)
                 .HasConstraintName("FK__SaleDetai__SaleI__6B24EA82");
        }
    }
}
