using System;
using System.Collections.Generic;
using System.Text;

namespace SocialOffice.Dtos
{
    public class ImageCreateDto
    {
        public Guid PostId { get; set; }
        public string ImageUrl { get; set; }
    }
}
