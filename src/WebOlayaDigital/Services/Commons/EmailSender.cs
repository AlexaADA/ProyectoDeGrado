using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebOlayaDigital.Services.Commons
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        private static readonly HttpClient HttpClient = new HttpClient();

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            string apiKey = _configuration.GetValue<string>("ConfigUrls:SendGrid");

            var client = new SendGridClient(HttpClient, new SendGridClientOptions { ApiKey = apiKey, HttpErrorAsException = true });

            // Send a Single Email using the Mail Helper
            var from = new EmailAddress("alexa.a.d.a1998@gmail.com");
            var to = new EmailAddress(email, "Example User");
            var plainTextContent = subject;
            var htmlContent = htmlMessage;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            _ = await client.SendEmailAsync(msg);

        }
    }
}
