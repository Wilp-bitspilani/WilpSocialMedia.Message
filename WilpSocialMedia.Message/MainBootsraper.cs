using WilpSocialMedia.Message.Application;
using WilpSocialMedia.Message.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message
{
    public static class MainBootsraper
    {
        public static void InitAppBootsraper(this IServiceCollection services)
        {
            RepositoryConfigurer.RegisterServices(services);
            ApplicationConfigurer.RegisterServices(services);
        }
    }
}
