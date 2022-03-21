using System.Collections.Generic;

namespace WebOlayaDigital.Models
{
    public class PostWhithMedia
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int? IdCategory { get; set; }
        public string NameCategory { get; set; }
        public int? IdUser { get; set; }
        public string NameUser { get; set; }

        public ICollection<MediaDto> MediaDto { get; set; }
    }
}
