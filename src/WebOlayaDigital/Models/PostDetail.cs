using System.Collections.Generic;

namespace WebOlayaDigital.Models
{
    public class PostDetail
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int IdPost { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public string UrlCategory { get; set; }

        public List<MediaDto> Media { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}
