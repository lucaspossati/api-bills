using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Data.Configuration
{
    public class SpentInMonthConfiguration : IEntityTypeConfiguration<SpentInMonth>
    {
        public void Configure(EntityTypeBuilder<SpentInMonth> builder)
        {
            builder.Property(x => x.Id).HasColumnName("id").IsRequired();

            builder.Property(p => p.Spent)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("spent")
                .IsRequired();

            builder.Property(p => p.SpendPercentageAbove)
                .HasColumnType("decimal(18,4)")
                .HasColumnName("spent_percentage_above")
                .IsRequired();
        }
    }
}
