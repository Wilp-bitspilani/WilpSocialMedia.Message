using WilpSocialMedia.Message.Domain.Model.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Infrastructure.Repositories
{
    public class RepositoryConfigurer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IMessageRepository, MessageRepository>();
            services.AddTransient<IConversationRepository, ConversationRepository>();
            services.AddTransient<IParticipantRepository, ParticipantRepository>();
            services.AddTransient<IActivityStatusRepository, ActivityStatusRepository>();
        }
    }
}
