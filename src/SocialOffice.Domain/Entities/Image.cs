using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SocialOffice.Entities
{
    public class Image: AuditedEntity<Guid>
    {
        public Guid PostId { get; set; }
        public Post Post { get; set; }
        public string ImageUrl { get; set; }
    }
}
