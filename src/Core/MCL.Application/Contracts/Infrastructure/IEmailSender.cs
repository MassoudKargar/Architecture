namespace MCL.Application.Contracts.Infrastructure;
public interface IEmailSender
{
    Task<bool> SendEmailAsync(Email email, CancellationToken cancellationToken);
}
