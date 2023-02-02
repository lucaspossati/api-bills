using api.Domain.VM.Shared;
using API.ValueObjects;
using System;

namespace API.Domain.VM{
    public class NotificationVM : BaseViewModel
    {
        public Guid Id { get; set; }

        public ETypeNotification Type { get; set; }

        public string? TypeName { get; set; }

        public string? Message { get; set; }

        public string? RecipientEmail { get; set; }

        public string? RecipientNumber { get; set; }

        public string? OriginEmail { get; set; }

        public string? Subject { get; set; }

        public string? ClientName { get; set; }

        public string? UserName { get; set; }
    }
}