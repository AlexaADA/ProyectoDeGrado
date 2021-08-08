using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    }
}
