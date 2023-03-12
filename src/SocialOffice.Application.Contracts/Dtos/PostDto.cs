using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SocialOffice.Dtos
{
    public class PostDto
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string PostMessage { get; set; }
        public List<ImageDto> Images { get; set; }
    }
}
