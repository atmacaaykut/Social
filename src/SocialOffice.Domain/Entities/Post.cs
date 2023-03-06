using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SocialOffice.Entities
{
    public class Post:AuditedEntity<Guid>
    {
        public Guid UserId { get; set; }
        public IdentityUserCustomized IdentityUser { get; set; }
        public string Title { get; set; }
        public string PostMessage { get; set; }
        public List<Image> Images { get; set; }
    }
}
