using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Domain.Models;
using API.ValueObjects;

namespace Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();

            builder.Property(p => p.Name).HasMaxLength(100).HasColumnName("name").IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).HasColumnName("email").IsRequired();
            builder.Property(p => p.Password).HasMaxLength(200).HasColumnName("password").IsRequired();

            builder.Property(p => p.Salary)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("salary")
                .IsRequired();

            builder.Property(p => p.SalarySave)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("salary_save")
                .IsRequired();

            builder.Property(p => p.Role).HasColumnName("role").IsRequired();
        }
    }
}
