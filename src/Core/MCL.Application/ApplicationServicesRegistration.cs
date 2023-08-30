namespace MCL.Application;
public static class ApplicationServicesRegistration
{
    public static void ConfigureApplicationService(this IServiceCollection services)
    {
        //services.AddAutoMapper(typeof(MappingProfile));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
