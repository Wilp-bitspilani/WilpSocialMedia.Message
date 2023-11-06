using WilpSocialMedia.Common.API.DTO;
using WilpSocialMedia.Message.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Domain.Services
{
    public interface IMessageService
    {
        (bool status, string message) SendMessage(SendMessageRequest request);
        List<AccountUserDto> ListUserConversation(Guid idUser);
        List<ListMessagesResponse> ListMessage(Guid idConversation);
    }
}
