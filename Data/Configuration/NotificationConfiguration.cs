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
            builder.Property(p => p.Id).HasColumnName("id").IsRequired();


            builder.Property(p => p.Message).HasColumnName("message")
                .HasMaxLength(400).IsRequired();

            builder.Property(p => p.RecipientEmail).HasColumnName("recipient_email")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.RecipientNumber).HasColumnName("recipient_number")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.OriginEmail).HasColumnName("origin_email")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.Subject).HasColumnName("subject")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.ClientName).HasColumnName("client_name")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.UserName).HasColumnName("user_name")
                .HasMaxLength(100).IsRequired();

            builder.Property(p => p.Type).HasColumnName("type").HasConversion(
                p => p.ToString(),
                p => (ETypeNotification)Enum.Parse(typeof(ETypeNotification), p));
        }
    }
}
