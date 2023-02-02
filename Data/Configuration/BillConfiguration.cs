using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.Domain.Models;
using API.ValueObjects;
using Application.Models;

namespace Data.Configuration
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();

            builder.Property(p => p.Name).HasMaxLength(100).HasColumnName("name").IsRequired();

            builder.Property(p => p.Value)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("salary")
                .IsRequired();
        }
    }
}
