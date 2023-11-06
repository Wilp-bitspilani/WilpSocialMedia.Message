using WilpSocialMedia.Common.Infrastructure.Interface;
using WilpSocialMedia.Common.Repositories;
using WilpSocialMedia.Message.Domain.Model;
using WilpSocialMedia.Message.Domain.Model.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Infrastructure.Repositories
{
    public class ConversationRepository : EfRepository<Conversation>, IConversationRepository
    {
        private readonly IDbContextFactory _dbContextFactory;
        private readonly Wilpsocialmedia_MessageContext _context;
        public ConversationRepository(Wilpsocialmedia_MessageContext context, IDbContextFactory dbContextFactory) : base(context)
        {
            _dbContextFactory = dbContextFactory;
            _context = context;
        }

    }
}
