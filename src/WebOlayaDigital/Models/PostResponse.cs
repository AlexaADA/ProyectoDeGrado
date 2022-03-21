using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class PostResponse
    {
        public string Msg { get; set; }
        public ICollection<PostWhithMedia> Data { get; set; }
    }

}
