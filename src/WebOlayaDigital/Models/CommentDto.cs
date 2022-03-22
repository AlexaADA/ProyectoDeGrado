namespace WebOlayaDigital.Models
{
    public class CommentDto
    {
        public string Description { get; set; }
        public int? IdPost { get; set; }
        public int? IdUser { get; set; }
        public string CommentUser { get; set; }
    }
}
