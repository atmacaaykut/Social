using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SocialOffice.Entities
{
    public class UserProfile: AuditedEntity<Guid>
    {
        public Guid UserId { get; set; }
        public IdentityUserCustomized IdentityUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Status { get; set; }
        public string NickName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
