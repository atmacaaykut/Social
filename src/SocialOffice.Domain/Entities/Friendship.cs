using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SocialOffice.Entities
{
    public class Friendship:AuditedEntity<Guid>
    {
        public Guid RequestorId { get; set; }
        public IdentityUserCustomized RequestorIdentityUser { get; set; }
        public Guid ReceiverId { get; set; }
        public IdentityUserCustomized ReceiverIdentityUser { get; set; }
        public bool IsApproved { get; set; }
    }
}
