using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace LeaveManagementSystem.Web.Services
{
    public class EmailSender(IConfiguration _configuration) : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromAddress = _configuration["EmailSettings:DefaultEmailAddress"];
            if (string.IsNullOrWhiteSpace(fromAddress))
            {
                throw new InvalidOperationException("Default email address is not configured.");
            }
            var smptServer = _configuration["EmailSettings:Server"];
            var smptPort = int.Parse(_configuration["EmailSettings:Port"] ?? "25");
            var message = new MailMessage
            {
                From = new MailAddress(fromAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };

            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smptServer, smptPort);
            await client.SendMailAsync(message);
        }
    }
}