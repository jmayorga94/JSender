using JSender.Contracts;
using JSender.Utility;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace JSender.Services
{
    public class MailService : IMailService
    {
        private MailSettings _mailSettings { get; }

        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task<bool> SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MailMessage()
            {
                From = new MailAddress(_mailSettings.Sender),
                Subject = subject,
                Body = message,
                IsBodyHtml = true
            };

            emailMessage.To.Add(new MailAddress(email));

            using (var client = new SmtpClient(_mailSettings.SmtpServer, _mailSettings.SmtpPort))
            {
                try
                {
                    await client.SendMailAsync(emailMessage);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
           
        }
    }
}
