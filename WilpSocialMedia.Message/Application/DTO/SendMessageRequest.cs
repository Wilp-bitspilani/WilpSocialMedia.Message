﻿using WilpSocialMedia.Common.API.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WilpSocialMedia.Message.Application.DTO
{
    public class SendMessageRequest
    {
        [Required]             
        public Guid UserSender { get; set; }
        [Required]
        public Guid UserReciever{ get; set; }
        [Required]
        public string Title { get; set; }
        public string ContentMessage { get; set; }
    }
}
