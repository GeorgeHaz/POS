﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infraestructure.Persistences.Contexts.Configuration
{
    internal class UsersBranchOfficeConfiguration : IEntityTypeConfiguration<UsersBranchOffice>
    {
        public void Configure(EntityTypeBuilder<UsersBranchOffice> builder)
        {
            builder.HasKey(e => e.UserBranchOfficeId).HasName("PK__UsersBra__7D1E804AC1EC5260");

            builder.HasOne(d => d.BranchOffice).WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.BranchOfficeId)
                .HasConstraintName("FK__UsersBran__Branc__70DDC3D8");

            builder.HasOne(d => d.User).WithMany(p => p.UsersBranchOffices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UsersBran__UserI__71D1E811");
        }
    }
}

