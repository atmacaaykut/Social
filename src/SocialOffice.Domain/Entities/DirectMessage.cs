using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SocialOffice.Entities
{
    public class DirectMessage:AuditedEntity<Guid>
    {
        public Guid FromUserId { get; set; }
        public IdentityUser FromIdentityUser { get; set; }
        public Guid ToUserId { get; set; }
        public IdentityUser ToIdentityUser { get; set; }
        public string Message { get; set; }
    }
}
