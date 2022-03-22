using System.Collections.Generic;

namespace WebOlayaDigital.Models
{
    public class HomeModel
    {
        public IEnumerable<Article> Article { get; set; }
        public List<PostWhithMedia> Post { get; set; }
        public List<(string name, string url)> Categories { get; set; }

    }
}
