using WilpSocialMedia.Common.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Application.DTO
{
    public class ListUserConversationRespond
    {
        public ListUserConversationRespond()
        {
            Users = new List<AccountUserDto>();
        }
        public Guid IdConversation { get; set; }
        public List<AccountUserDto> Users{ get; set; }
    }
}
