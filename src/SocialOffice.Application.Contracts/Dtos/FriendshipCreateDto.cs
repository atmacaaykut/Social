using System;
using System.Collections.Generic;
using System.Text;

namespace SocialOffice.Dtos
{
    public class FriendshipCreateDto
    {
        public Guid RequestorId { get; set; }
        public Guid ReceiverId { get; set; }
        public bool IsApproved { get; set; }
    }
}
