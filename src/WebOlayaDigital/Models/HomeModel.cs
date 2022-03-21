using System.Collections.Generic;

namespace WebOlayaDigital.Models
{
    public class HomeModel
    {
        public IEnumerable<Article> Article { get; set; }
        public PostResponse Post { get; set; }
    }
}
