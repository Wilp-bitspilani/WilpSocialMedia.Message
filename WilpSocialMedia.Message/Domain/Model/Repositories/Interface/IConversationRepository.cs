using WilpSocialMedia.Common.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Domain.Model.Repositories.Interface
{
    public interface IConversationRepository : IEfRepository<Conversation>
    {
    }
}
