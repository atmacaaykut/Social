using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Auditing;
using Volo.Abp.Guids;
using Volo.Abp.Identity;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace SocialOffice.Entities
{
    public class IdentityUserCustomized :IdentityUser
    {
        public List<DirectMessage> DirectMessagesSender { get; set; }
        public List<DirectMessage> DirectMessagesReceiver { get; set; }
        public List<Friendship> FriendshipSenders { get; set; }
        public List<Friendship> FriendshipReceivers { get; set; }
        public List<Post> Posts { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
