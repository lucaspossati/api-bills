using API.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Domain.Models{
    public class Notification
    {
        public Guid Id { get; set; }

        public ETypeNotification Type { get; set; }

        public string? Message { get; set; }

        public string? RecipientEmail { get; set; }

        public string? RecipientNumber { get; set; }

        public string? OriginEmail { get; set; }

        public string? Subject { get; set; }

        public string? ClientName { get; set; }

        public string? UserName { get; set; }
    }
}