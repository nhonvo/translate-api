namespace api.Extensions;

public static class CorsExtension
{
    public static IServiceCollection AddCorsCustom(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(
                policy =>
                {
                    policy.WithOrigins("https://nhonvo.github.io/translate/", "http://localhost:3000");
                });
        });

        return services;
    }
}
