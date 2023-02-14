using SendGrid;

namespace api.Domain.Services.Interfaces
{
    public interface IEmailService
    {
        Task<Response> SendEmail(string email, string name, string subject, string? token, Guid idUser);
    }
}
