﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configuration
{
    public class ProvinceConfiguration : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.HasKey(e => e.ProvinceId).HasName("PK__Province__FD0A6F8386F65284");

            builder.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.HasOne(d => d.Department).WithMany(p => p.Provinces)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Provinces__Depar__656C112C");
        }
    }
}