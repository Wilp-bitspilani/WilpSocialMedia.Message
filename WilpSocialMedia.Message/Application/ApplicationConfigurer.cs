using WilpSocialMedia.Message.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace WilpSocialMedia.Message.Application
{
    public class ApplicationConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IMessageService, MessageService>();
        }
    }
}
