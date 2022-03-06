namespace OlayaDigital.Core.DTOs
{
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
