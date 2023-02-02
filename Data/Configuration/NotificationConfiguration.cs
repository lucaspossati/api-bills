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
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(p => p.Assunto).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Mensagem).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Tipo).HasConversion(
                p => p.ToString(),
                p => (ETypeNotification)Enum.Parse(typeof(ETypeNotification), p));
        }
    }
}
