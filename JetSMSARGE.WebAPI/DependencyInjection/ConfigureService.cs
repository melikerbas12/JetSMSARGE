using System.Net.Security;
using JetSMSARGE.WebAPI.ApiClientServices.JetSMS;

namespace JetSMSARGE.WebAPI.DependencyInjection
{
    public static class ConfigureService
    {

        public static IServiceCollection AddConfigureHttpClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();


            services.AddHttpClient<IJetSMSApiClient, JetSMSApiClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri(configuration["JetSMSURL"]!);
            })
            .ConfigureHttpClient((c) =>
                  new HttpClientHandler
                  {
                      ServerCertificateCustomValidationCallback = (sender, cert, chain,
                      sslPolicyErrors) =>
                      {
                          return sslPolicyErrors == SslPolicyErrors.None;
                      }
                  })
                .SetHandlerLifetime(TimeSpan.FromMinutes(5));

            return services;
        }

        public static IServiceCollection AddConfigureInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IJetSMSApiClient, JetSMSApiClient>();

            return services;
        }

    }
}