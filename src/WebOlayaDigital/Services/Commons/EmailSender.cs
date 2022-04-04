using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebOlayaDigital.Services.Commons
{
    public class EmailSender : IEmailSender
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            string apiKey = Environment.GetEnvironmentVariable("SendGrid");

            var client = new SendGridClient(HttpClient, new SendGridClientOptions { ApiKey = apiKey, HttpErrorAsException = true });

            // Send a Single Email using the Mail Helper
            try
            {
                var from = new EmailAddress("alexa.a.d.a1998@gmail.com");
                var to = new EmailAddress(email, "Example User");
                var plainTextContent = subject;
                var htmlContent = htmlMessage;
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                _ = await client.SendEmailAsync(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
