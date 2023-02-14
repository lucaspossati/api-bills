

using api.Domain.Services.Interfaces;
using Manager.Shared;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace api.Domain.Services
{
    public class EmailService: IEmailService
    {
        private readonly IConfiguration configuration;

        public EmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<Response> SendEmail(string email, string name, string subject, string? token, Guid idUser)
        {
            var apiKey = configuration.GetSection("SendGrid:Secret").Value;
            var urlActivate = (configuration.GetSection("Environment:FrontLocal").Value) + "/auth/activate-user/" + token + "/" + idUser;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("lucasdavipossati@hotmail.com", "Bill");
            var to = new EmailAddress(email, name);
            var plainTextContent = "";
            var htmlContent = EmailTemplate.EmailCreatedUser(urlActivate);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return response;
        }
    }
}
