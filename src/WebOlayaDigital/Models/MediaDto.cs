using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebOlayaDigital.Models
{
    public class MediaResponse
    {
        public string Msg { get; set; }
        public MediaDto Data { get; set; }
    }
    public class MediaDto
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int? IdPost { get; set; }
        public string Extension { get; set; }
        public float FileSize { get; set; }
        public string Route { get; set; }
        public bool Cover { get; set; }
    }
}
