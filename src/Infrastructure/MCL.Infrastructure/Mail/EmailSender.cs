using System.Net;
using SendGrid.Helpers.Mail;

namespace MCL.Infrastructure.Mail;

public class EmailSender : IEmailSender
{
    public EmailSender(IOptions<EmailSetting> emailSetting)
    {
        EmailSetting = emailSetting.Value;
    }

    private EmailSetting EmailSetting { get; }
    public async Task<bool> SendEmailAsync(Email email, CancellationToken cancellationToken)
    {
        var client = new SendGridClient(EmailSetting.ApiKey);
        var to = new EmailAddress(email.To);
        var from = new EmailAddress()
        {
            Email = EmailSetting.FromAddress,
            Name = EmailSetting.FromName
        };
        var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body, email.Body);
        var response = await client.SendEmailAsync(message, cancellationToken);
        return response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Accepted;
    }
}
