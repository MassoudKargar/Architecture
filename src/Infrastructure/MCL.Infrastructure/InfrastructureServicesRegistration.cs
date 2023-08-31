namespace MCL.Infrastructure;
public static class InfrastructureServicesRegistration
{
    public static void ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSetting>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
    }

}
