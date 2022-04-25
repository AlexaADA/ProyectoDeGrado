using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public int? IdCategory { get; set; }
        public int? IdUser { get; set; }
    }
}
